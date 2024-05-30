using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants.OrderShipItemStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;

public class CreateOrderShipItemStockCommand : IRequest<CreatedOrderShipItemStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItemStocks";

    public CreateOrderShipItemStockDto OrderShipItemStock { get; set; }
    public OrderShipItemStocksDetailLevel? DetailLevel { get; set; }

    public class CreateOrderShipItemStockCommandHandler : IRequestHandler<CreateOrderShipItemStockCommand, CreatedOrderShipItemStockResponse>
    {
        private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemStockBusinessRules _orderShipItemStockBusinessRules;

        public CreateOrderShipItemStockCommandHandler(IOrderShipItemStockRepository orderShipItemStockRepository, IMapper mapper, OrderShipItemStockBusinessRules orderShipItemStockBusinessRules)
        {
            _orderShipItemStockRepository = orderShipItemStockRepository;
            _mapper = mapper;
            _orderShipItemStockBusinessRules = orderShipItemStockBusinessRules;
        }

        public async Task<CreatedOrderShipItemStockResponse> Handle(CreateOrderShipItemStockCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemStockBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            OrderShipItemStock? orderShipItemStock = _mapper.Map<OrderShipItemStock>(request.OrderShipItemStock);

            orderShipItemStock.CreatedDate = DateTime.Now;
            orderShipItemStock.Id = Guid.NewGuid();

            await _orderShipItemStockRepository.AddAsync(orderShipItemStock);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderShipItemStockRepository.GetAsync(predicate: x => x.Id == orderShipItemStock.Id,
                include: x =>
                {
                    IQueryable<OrderShipItemStock> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrderShipItem)
                    {
                        query = query.Include(y => y.OrderShipItem);
                    }

                    if (detailLevel.IncludeOrderShipItemTask)
                    {
                        query = query.Include(y => y.OrderShipItemTask);
                    }

                    if (detailLevel.IncludeStockPackType)
                    {
                        query = query.Include(y => y.StockPackType);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    var includableQuery = query as IIncludableQueryable<OrderShipItemStock, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderShipItemStockResponse>(response);
            }
            else
            {
                var response = await _orderShipItemStockRepository.GetAsync(predicate: x => x.Id == orderShipItemStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderShipItemStockResponse>(response);
            }
        }
    }
}

