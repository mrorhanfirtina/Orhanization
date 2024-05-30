using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Create;

public class CreateOrderItemCommand : IRequest<CreatedOrderItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderItems";

    public CreateOrderItemDto OrderItem { get; set; }
    public OrderItemsDetailLevel DetailLevel { get; set; }


    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, CreatedOrderItemResponse>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IOrderShipmentRepository _orderShipmentRepository;

        public CreateOrderItemCommandHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules, IOrderShipmentRepository orderShipmentRepository)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
            _orderItemBusinessRules = orderItemBusinessRules;
            _orderShipmentRepository = orderShipmentRepository;
        }

        public async Task<CreatedOrderItemResponse> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            OrderItem? orderItem = _mapper.Map<OrderItem>(request.OrderItem);

            OrderShipment? orderShipment = await _orderShipmentRepository.GetAsync(predicate: x => x.OrderId == orderItem.OrderId,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);


            _orderItemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckOrderShipment(orderShipment);

            orderItem.CreatedDate = DateTime.Now;
            orderItem.Id = Guid.NewGuid();

            orderItem.OrderItemMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            orderItem.OrderItemStockAttrValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            orderItem.OrderShipItems?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
                x.ProgressStatusId = 1;
                x.OrderShipmentId = orderShipment.Id;
                x.Quantity = orderItem.Quantity;
            });

            await _orderItemRepository.AddAsync(orderItem);

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

                return _mapper.Map<CreatedOrderItemResponse>(response);
            }
            else
            {
                var response = await _orderItemRepository.GetAsync(predicate: x => x.Id == orderItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderItemResponse>(response);
            }
        }
    }

}
