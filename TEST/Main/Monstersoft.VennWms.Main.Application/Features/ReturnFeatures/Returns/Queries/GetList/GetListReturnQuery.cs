using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;

public class GetListReturnQuery : IRequest<GetListResponse<GetListReturnListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListReturnQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetReturns";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListReturnQueryHandler : IRequestHandler<GetListReturnQuery, GetListResponse<GetListReturnListItemDto>>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;
        private readonly IMapper _mapper;

        public GetListReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<GetListResponse<GetListReturnListItemDto>> Handle(GetListReturnQuery request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Return> returnList = await _returnRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
             include: x => x.Include(y => y.ReturnAttributeValues)
                            .Include(y => y.ReturnMemos)
                            .Include(y => y.ReturnItems)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItemMemos)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItmStockAttrValues),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListReturnListItemDto>>(returnList);
        }
    }

}
