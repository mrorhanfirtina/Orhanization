using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Update;

public class UpdateOrderItemCommand : IRequest<UpdatedOrderItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItems"];

    public UpdateOrderItemDto OrderItem { get; set; }
    public OrderItemsDetailLevel DetailLevel { get; set; }


    public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, UpdatedOrderItemResponse>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IOrderShipmentRepository _orderShipmentRepository;

        public UpdateOrderItemCommandHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules, IOrderShipmentRepository orderShipmentRepository)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
            _orderItemBusinessRules = orderItemBusinessRules;
            _orderShipmentRepository = orderShipmentRepository;
        }

        public async Task<UpdatedOrderItemResponse> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
        {
            OrderItem? currentOrderItem = await _orderItemRepository.GetAsync(predicate: x => x.Id == request.OrderItem.Id,
              include: x => x.Include(y => y.OrderItemMemos)
                              .Include(y => y.OrderItemStockAttrValues)
                              .Include(y => y.OrderShipItems),
              withDeleted: false,
              enableTracking: true,
              cancellationToken: cancellationToken);

            OrderShipment? orderShipment = await _orderShipmentRepository.GetAsync(predicate: x => x.OrderId == currentOrderItem.OrderId,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            _orderItemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
            .CheckIdExistence(request.OrderItem.Id)
            .CheckOrderShipment(orderShipment);

            OrderItem? orderItem = _mapper.Map(request.OrderItem, currentOrderItem);

            orderItem.UpdatedDate = DateTime.Now;

            orderItem.OrderItemMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = orderItem.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            orderItem.OrderItemStockAttrValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = orderItem.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            orderItem.OrderShipItems?.ToList().ForEach(x =>
            {
                x.CreatedDate = orderItem.CreatedDate;
                x.UpdatedDate = DateTime.Now;
                x.ProgressStatusId = 1;
                x.OrderShipmentId = orderShipment.Id;
                x.Quantity = orderItem.Quantity;
            });


            await _orderItemRepository.UpdateAsync(orderItem);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderItemRepository.GetAsync(predicate: x => x.Id == orderItem.Id,
                include: x =>
                {
                    IQueryable<OrderItem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludeOrderItemMemo)
                    {
                        query = query.Include(y => y.OrderItemMemos);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(y => y.Unit);
                        }
                    }

                    if (detailLevel.IncludeOrderShipItem)
                    {
                        query = query.Include(y => y.OrderShipItems);

                        if (detailLevel.OrderShipItemDetailLevel.IncludeProgressStatus)
                        {
                            query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.ProgressStatus);
                        }
                    }

                    if (detailLevel.IncludeOrderItemStockAttrValue)
                    {
                        query = query.Include(y => y.OrderItemStockAttrValues);

                        if (detailLevel.OrderItemStockAttrValueDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.OrderItemStockAttrValues).ThenInclude(y => y.StockAttribute);

                            if (detailLevel.OrderItemStockAttrValueDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.OrderItemStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<OrderItem, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemResponse>(response);
            }
            else
            {
                var response = await _orderItemRepository.GetAsync(predicate: x => x.Id == orderItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemResponse>(response);
            }
        }
    }
}
