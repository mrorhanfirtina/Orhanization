using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants.StockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Queries.GetList;

public class GetListStockQuery : IRequest<GetListResponse<GetListStockListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListStockQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetStocks";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListStockQueryHandler : IRequestHandler<GetListStockQuery, GetListResponse<GetListStockListItemDto>>
    {
        private readonly IStockRepository _stockRepository;
        private readonly StockBusinessRules _stockBusinessRules;
        private readonly IMapper _mapper;

        public GetListStockQueryHandler(IStockRepository stockRepository, IMapper mapper, StockBusinessRules stockBusinessRules)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
            _stockBusinessRules = stockBusinessRules;
        }

        public async Task<GetListResponse<GetListStockListItemDto>> Handle(GetListStockQuery request, CancellationToken cancellationToken)
        {
            _stockBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Stock> stockList = await _stockRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(m => m.StockContainer)
                           .Include(m => m.StockAttributeValues)
                           .Include(m => m.StockAttributeValues).ThenInclude(m => m.StockAttribute)
                           .Include(m => m.StockAttributeValues).ThenInclude(m => m.StockAttribute).ThenInclude(m => m.AttributeInputType)
                           .Include(m => m.StockMemos)
                           .Include(m => m.StockReserveReasons)
                           .Include(m => m.StockReserveReasons).ThenInclude(m => m.ReserveReason)
                           .Include(m => m.StockUnsuitReasons)
                           .Include(m => m.StockUnsuitReasons).ThenInclude(m => m.UnsuitReason)
                           .Include(m => m.StockInbounds)
                           .Include(m => m.StockInbounds).ThenInclude(m => m.Return)
                           .Include(m => m.StockInbounds).ThenInclude(m => m.Receipt)
                           .Include(m => m.Product)
                           .Include(m => m.Depositor)
                           .Include(m => m.Depositor).ThenInclude(v => v.Company)
                           .Include(m => m.DepositorCompany)
                           .Include(m => m.Location)
                           .Include(m => m.CuItemUnit)
                           .Include(m => m.CuItemUnit).ThenInclude(v => v.Unit),
            orderBy: x => x.OrderByDescending(m => m.CreatedDate),
            index: request.PageRequest.PageIndex, enableTracking: false,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListStockListItemDto>>(stockList);
        }
    }

}

