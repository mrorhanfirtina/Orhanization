using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;

public class CreateOrderCommand : IRequest<CreatedOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrders"];

    public CreateOrderDto Order { get; set; }
    public OrdersDetailLevel DetailLevel { get; set; }


    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreatedOrderResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly OrderBusinessRules _orderBusinessRules;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<CreatedOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Order? order = _mapper.Map<Order>(request.Order);

            order.CreatedDate = DateTime.Now;
            order.InputDate = DateTime.Now;
            order.Id = Guid.NewGuid();
            order.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);
            order.StatusId = 1;

            order.OrderShipments.Add(new OrderShipment
            {
                CreatedDate = DateTime.Now,
                DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId),
                OrderId = order.Id,
                Code = order.Code,
                ProgressStatusId = 1,
                Id = Guid.NewGuid()
            });

            order.OrderItems.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.OrderItemMemos?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
                x.OrderItemStockAttrValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });

                x.OrderShipItems.Add(new OrderShipItem
                {
                    CreatedDate = DateTime.Now,
                    ProgressStatusId = 1,
                    OrderShipmentId = order.OrderShipments.FirstOrDefault().Id,
                    Quantity = x.Quantity,
                    Id = Guid.NewGuid()
                });
            });

            order.OrderAttributeValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            order.OrderMemos?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            if (order.OrderPriority != null)
            {
                order.OrderPriority.CreatedDate = DateTime.Now;
            }

            await _orderRepository.AddAsync(order);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderRepository.GetAsync(predicate: x => x.Id == order.Id,
                include: x =>
                {
                    IQueryable<Order> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeOrderType)
                    {
                        query = query.Include(y => y.OrderType);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludeOrderMemo)
                    {
                        query = query.Include(y => y.OrderMemos);
                    }

                    if (detailLevel.IncludeCustomer)
                    {
                        query = query.Include(y => y.Customer);

                        if (detailLevel.CustomerDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Customer).ThenInclude(m => m.Company);
                        }

                        if (detailLevel.CustomerDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Customer).ThenInclude(m => m.Address);
                        }
                    }

                    if (detailLevel.IncludeReceiver)
                    {
                        query = query.Include(y => y.Receiver);

                        if (detailLevel.ReceiverDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Receiver).ThenInclude(m => m.Address);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        if (detailLevel.DepositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(m => m.Company);
                        }
                    }

                    if (detailLevel.IncludeOrderPriority)
                    {
                        query = query.Include(y => y.OrderPriority);

                        if (detailLevel.OrderPriorityDetailLevel.IncludePriorityList)
                        {
                            query = query.Include(y => y.OrderPriority).ThenInclude(m => m.Priority);
                        }
                    }

                    if (detailLevel.IncludeOrderAttributeValue)
                    {
                        query = query.Include(y => y.OrderAttributeValues);

                        if (detailLevel.OrderAttributeValueDetailLevel.IncludeOrderAttribute)
                        {
                            query = query.Include(y => y.OrderAttributeValues).ThenInclude(m => m.OrderAttribute);
                        }

                        if (detailLevel.OrderAttributeValueDetailLevel.OrderAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.OrderAttributeValues).ThenInclude(m => m.OrderAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }

                    if (detailLevel.IncludeOrderShipment)
                    {
                        query = query.Include(y => y.OrderShipments);

                        if (detailLevel.OrderShipmentDetailLevel.IncludeShipment)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(m => m.Shipment);
                        }

                        if (detailLevel.OrderShipmentDetailLevel.IncludeProgressStatus)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(m => m.ProgressStatus);
                        }
                    }

                    if (detailLevel.IncludeOrderItem)
                    {
                        query = query.Include(y => y.OrderItems);

                        if (detailLevel.OrderItemDetailLevel.IncludeOrderItemMemo)
                        {
                            query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderItemMemos);
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.OrderItems).ThenInclude(m => m.Product);
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeOrderItemStockAttrValue)
                        {
                            query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderItemStockAttrValues);

                            if (detailLevel.OrderItemDetailLevel.StockAttrValueDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderItemStockAttrValues).ThenInclude(m => m.StockAttribute);

                                if (detailLevel.OrderItemDetailLevel.StockAttrValueDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderItemStockAttrValues).ThenInclude(m => m.StockAttribute).ThenInclude(m => m.AttributeInputType);
                                }
                            }
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.OrderItems).ThenInclude(m => m.ItemUnit);

                            if (detailLevel.OrderItemDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.OrderItems).ThenInclude(m => m.ItemUnit).ThenInclude(m => m.Unit);
                            }
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeOrderShipItem)
                        {
                            query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderShipItems);

                            if (detailLevel.OrderItemDetailLevel.OrderShipItemDetailLevel.IncludeProgressStatus)
                            {
                                query = query.Include(y => y.OrderItems).ThenInclude(m => m.OrderShipItems).ThenInclude(m => m.ProgressStatus);
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Order, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderResponse>(response);
            }
            else
            {
                var response = await _orderRepository.GetAsync(predicate: x => x.Id == order.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderResponse>(response);
            }
        }
    }
}
