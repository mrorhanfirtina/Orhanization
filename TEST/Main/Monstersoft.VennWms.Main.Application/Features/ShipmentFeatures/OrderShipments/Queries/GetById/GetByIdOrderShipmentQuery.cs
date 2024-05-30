using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants.OrderShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Queries.GetById;

public class GetByIdOrderShipmentQuery : IRequest<GetByIdOrderShipmentResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderShipmentsDetailLevel? DetailLevel { get; set; }


    public class GetByIdOrderShipmentQueryHandler : IRequestHandler<GetByIdOrderShipmentQuery, GetByIdOrderShipmentResponse>
    {
        private readonly IOrderShipmentRepository _orderShipmentRepository;
        private readonly OrderShipmentBusinessRules _orderShipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderShipmentQueryHandler(IOrderShipmentRepository orderShipmentRepository, IMapper mapper, OrderShipmentBusinessRules orderShipmentBusinessRules)
        {
            _orderShipmentRepository = orderShipmentRepository;
            _mapper = mapper;
            _orderShipmentBusinessRules = orderShipmentBusinessRules;
        }

        public async Task<GetByIdOrderShipmentResponse> Handle(GetByIdOrderShipmentQuery request, CancellationToken cancellationToken)
        {
            _orderShipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderShipmentResponse>(await _orderShipmentRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderShipmentResponse>(await _orderShipmentRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
