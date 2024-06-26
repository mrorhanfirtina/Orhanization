﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;

public class GetByIdOrderQuery : IRequest<GetByIdOrderResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrdersDetailLevel DetailLevel { get; set; }


    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQuery, GetByIdOrderResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<GetByIdOrderResponse> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderResponse>(await _orderRepository.GetAsync(x => x.Id == request.Id,
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
                        query = query.Include(y => y.OrderShipment);

                        if (detailLevel.OrderShipmentDetailLevel.IncludeShipment)
                        {
                            query = query.Include(y => y.OrderShipment).ThenInclude(m => m.Shipment);
                        }

                        if (detailLevel.OrderShipmentDetailLevel.IncludeProgressStatus)
                        {
                            query = query.Include(y => y.OrderShipment).ThenInclude(m => m.ProgressStatus);
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderResponse>(await _orderRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
