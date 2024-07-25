using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetList;

public class GetListTaskCodeFormatQuery : IRequest<GetListResponse<GetListTaskCodeFormatListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];
    public string CacheKey => $"GetListTaskCodeFormatQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetTaskCodeFormats";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListTaskCodeFormatQueryHandler : IRequestHandler<GetListTaskCodeFormatQuery, GetListResponse<GetListTaskCodeFormatListItemDto>>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;
        private readonly IMapper _mapper;

        public GetListTaskCodeFormatQueryHandler(ITaskCodeFormatRepository taskCodeFormatRepository, IMapper mapper, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _mapper = mapper;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
        }

        public async Task<GetListResponse<GetListTaskCodeFormatListItemDto>> Handle(GetListTaskCodeFormatQuery request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TaskCodeFormat> taskCodeFormatList = await _taskCodeFormatRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(x => x.DepositorCompany).Include(x => x.TransactionType),
            orderBy: x => x.OrderByDescending(m => m.CreatedDate),
            index: request.PageRequest.PageIndex, enableTracking: false,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListTaskCodeFormatListItemDto>>(taskCodeFormatList);
        }
    }

}

