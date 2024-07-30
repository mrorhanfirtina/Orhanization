using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetList;

public class GetListUnsuitReasonQuery : IRequest<GetListResponse<GetListUnsuitReasonListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string CacheKey => $"GetListUnsuitReasonQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache {get;}
    public string? CacheGroupKey => "GetUnsuitReasons";
    public TimeSpan? SlidingExpiration { get; }
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [];

    public PageRequest PageRequest { get; set; }


    public class GetListUnsuitReasonQueryHandler : IRequestHandler<GetListUnsuitReasonQuery, GetListResponse<GetListUnsuitReasonListItemDto>>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListUnsuitReasonQueryHandler(IUnsuitReasonRepository unsuitReasonRepository, IMapper mapper, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _mapper = mapper;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
        }

        public async Task<GetListResponse<GetListUnsuitReasonListItemDto>> Handle(GetListUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<UnsuitReason> unsuitReasonList = await _unsuitReasonRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(m => m.DepositorCompany),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListUnsuitReasonListItemDto>>(unsuitReasonList);
        }
    }


}
