using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Update;

public class UpdateOrderShipItemStockCommand : IRequest<UpdatedOrderShipItemStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipItemStockOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItemStocks";

    public UpdateOrderShipItemStockDto OrderShipItemStock { get; set; }
    public OrderShipItemStocksDetailLevel? DetailLevel { get; set; }


    public class UpdateOrderShipItemStockCommandHandler : IRequestHandler<UpdateOrderShipItemStockCommand, UpdatedOrderShipItemStockResponse>
    {
        private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemStockBusinessRules _orderShipItemStockBusinessRules;

        public UpdateOrderShipItemStockCommandHandler(IOrderShipItemStockRepository orderShipItemStockRepository, IMapper mapper, OrderShipItemStockBusinessRules orderShipItemStockBusinessRules)
        {
            _orderShipItemStockRepository = orderShipItemStockRepository;
            _mapper = mapper;
            _orderShipItemStockBusinessRules = orderShipItemStockBusinessRules;
        }

        public async Task<UpdatedOrderShipItemStockResponse> Handle(UpdateOrderShipItemStockCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemStockBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipItemStock.Id);

            OrderShipItemStock? currentOrderShipItemStock = await _orderShipItemStockRepository.GetAsync(predicate: x => x.Id == request.OrderShipItemStock.Id,
            withDeleted: false,enableTracking: true,cancellationToken: cancellationToken);

            OrderShipItemStock? orderShipItemStock = _mapper.Map(request.OrderShipItemStock, currentOrderShipItemStock);

            orderShipItemStock.UpdatedDate = DateTime.Now;

            await _orderShipItemStockRepository.UpdateAsync(orderShipItemStock);

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

                return _mapper.Map<UpdatedOrderShipItemStockResponse>(response);
            }
            else
            {
                var response = await _orderShipItemStockRepository.GetAsync(predicate: x => x.Id == orderShipItemStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipItemStockResponse>(response);
            }
        }
    }
}

