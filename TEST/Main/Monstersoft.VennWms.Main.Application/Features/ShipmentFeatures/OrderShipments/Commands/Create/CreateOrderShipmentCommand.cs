using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;

public class CreateOrderShipmentCommand : IRequest<CreatedOrderShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderShipments"];


    public CreateOrderShipmentDto OrderShipment { get; set; }
    public OrderShipmentsDetailLevel? DetailLevel { get; set; }


    public class CreateOrderShipmentCommandHandler : IRequestHandler<CreateOrderShipmentCommand, CreatedOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;

        public CreateOrderShipmentCommandHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<CreatedOrderShipmentResponse> Handle(CreateOrderShipmentCommand request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            OrderShipment? orderShipment = _mapper.Map<OrderShipment>(request.OrderShipment);

            orderShipment.CreatedDate = DateTime.Now;
            orderShipment.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            orderShipment.OrderShipItems.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            await _orderShipmentRepository.AddAsync(orderShipment);

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

                return _mapper.Map<CreatedOrderShipmentResponse>(response);
            }
            else
            {
                var response = await _orderShipmentRepository.GetAsync(predicate: x => x.Id == orderShipment.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedOrderShipmentResponse>(response);
            }
        }
    }
}
