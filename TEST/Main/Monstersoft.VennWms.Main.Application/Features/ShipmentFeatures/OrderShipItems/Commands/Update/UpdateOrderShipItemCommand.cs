using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;

public class UpdateOrderShipItemCommand : IRequest<UpdatedOrderShipItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItems";

    public UpdateOrderShipItemDto OrderShipItem { get; set; }
    public OrderShipItemsDetailLevel? DetailLevel { get; set; }


    public class UpdateOrderShipItemCommandHandler : IRequestHandler<UpdateOrderShipItemCommand, UpdatedOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;

        public UpdateOrderShipItemCommandHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _mapper = mapper;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<UpdatedOrderShipItemResponse> Handle(UpdateOrderShipItemCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipItem.Id);

            OrderShipItem? currentOrderShipItem = await _orderShipItemRepository.GetAsync(predicate: x => x.Id == request.OrderShipItem.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            OrderShipItem? orderShipItem = _mapper.Map(request.OrderShipItem, currentOrderShipItem);

            orderShipItem.UpdatedDate = DateTime.Now;

            await _orderShipItemRepository.UpdateAsync(orderShipItem);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderShipItemRepository.GetAsync(predicate: x => x.Id == orderShipItem.Id,
                include: x =>
                {
                    IQueryable<OrderShipItem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeProgressStatus)
                    {
                        query = query.Include(y => y.ProgressStatus);
                    }

                    if (detailLevel.IncludeOrderItem)
                    {
                        query = query.Include(y => y.OrderItem);

                        if (detailLevel.OrderItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(y => y.Product);
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(y => y.ItemUnit);

                            if (detailLevel.OrderItemDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.OrderItem).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    if (detailLevel.IncludeOrderShipment)
                    {
                        query = query.Include(y => y.OrderShipment);

                        if (detailLevel.OrderShipmentDetailLevel.IncludeShipment)
                        {
                            query = query.Include(y => y.OrderShipment).ThenInclude(y => y.Shipment);
                        }
                    }

                    if (detailLevel.IncludeOrderShipItemTask)
                    {
                        query = query.Include(y => y.OrderShipItemTasks);

                        if (detailLevel.OrderShipItemTaskDetailLevel.IncludeOrderShipItemStock)
                        {
                            query = query.Include(y => y.OrderShipItemTasks).ThenInclude(y => y.OrderShipItemStocks);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<OrderShipItem, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipItemResponse>(response);
            }
            else
            {
                var response = await _orderShipItemRepository.GetAsync(predicate: x => x.Id == orderShipItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipItemResponse>(response);
            }
        }
    }
}
