using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Update;

public class UpdateOrderShipmentCommand : IRequest<UpdatedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipmentOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipments";

    public UpdateOrderShipmentDto OrderShipment { get; set; }
    public OrderShipmentsDetailLevel? DetailLevel { get; set; }


    public class UpdateOrderShipmentCommandHandler : IRequestHandler<UpdateOrderShipmentCommand, UpdatedOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;

        public UpdateOrderShipmentCommandHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<UpdatedOrderShipmentResponse> Handle(UpdateOrderShipmentCommand request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipment.Id);

            OrderShipment? currentOrderShipment = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == request.OrderShipment.Id,
            include: x => x.Include(y => y.OrderShipItems),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderShipment? orderShipment = _mapper.Map(request.OrderShipment, currentOrderShipment);
            orderShipment.UpdatedDate = DateTime.Now;

            orderShipment.OrderShipItems.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = orderShipment.CreatedDate;
            });

            await _orderShipmentRepository.UpdateAsync(currentOrderShipment);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == orderShipment.Id,
                include: x =>
                {
                    IQueryable<OrderShipment> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeShipment)
                    {
                        query = query.Include(y => y.Shipment);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeProgressStatus)
                    {
                        query = query.Include(y => y.ProgressStatus);
                    }

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludeOrderShipItem)
                    {
                        query = query.Include(y => y.OrderShipItems);

                        if (detailLevel.OrderShipItemDetailLevel.IncludeOrderItem)
                        {
                            query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderItem);

                            if (detailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.IncludeProduct)
                            {
                                query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.Product);
                            }

                            if (detailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.IncludeItemUnit)
                            {
                                query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.ItemUnit);

                                if (detailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                                {
                                    query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                                }
                            }
                        }

                        if (detailLevel.OrderShipItemDetailLevel.IncludeOrderShipItemTasks)
                        {
                            query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks);

                            if (detailLevel.OrderShipItemDetailLevel.OrderShipItemTaskDetailLevel.IncludeOrderShipItemStock)
                            {
                                query = query.Include(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks).ThenInclude(y => y.OrderShipItemStocks);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<OrderShipment, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipmentResponse>(response);
            }
            else
            {
                var response = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == orderShipment.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderShipmentResponse>(response);
            }
        }
    }
}
