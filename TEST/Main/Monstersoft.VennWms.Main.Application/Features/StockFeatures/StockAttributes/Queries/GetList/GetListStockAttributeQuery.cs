using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetList;

public class GetListStockAttributeQuery : IRequest<GetListResponse<GetListStockAttributeListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListStockAttributeQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetStockAttributes";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListStockAttributeQueryHandler : IRequestHandler<GetListStockAttributeQuery, GetListResponse<GetListStockAttributeListItemDto>>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetListStockAttributeQueryHandler(IStockAttributeRepository stockAttributeRepository, IMapper mapper, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _mapper = mapper;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
        }

        public async Task<GetListResponse<GetListStockAttributeListItemDto>> Handle(GetListStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<StockAttribute> stockAttributeList = await _stockAttributeRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(i => i.AttributeInputType).Include(x => x.DepositorCompany),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListStockAttributeListItemDto>>(stockAttributeList);
        }
    }

}
