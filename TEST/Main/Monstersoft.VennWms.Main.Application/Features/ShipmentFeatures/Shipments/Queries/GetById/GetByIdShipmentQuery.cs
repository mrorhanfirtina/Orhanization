using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetById;

public class GetByIdShipmentQuery : IRequest<GetByIdShipmentResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ShipmentsDetailLevel? DetailLevel { get; set; }


    public class GetByIdShipmentQueryHandler : IRequestHandler<GetByIdShipmentQuery, GetByIdShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdShipmentQueryHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<GetByIdShipmentResponse> Handle(GetByIdShipmentQuery request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdShipmentResponse>(await _shipmentRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<Shipment> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrderShipment)
                    {
                        query = query.Include(y => y.OrderShipments);

                        if (detailLevel.OrderShipmentDetailLevel.IncludeOrder)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(y => y.Order);
                        }

                        if (detailLevel.OrderShipmentDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(y => y.DepositorCompany);
                        }

                        if (detailLevel.OrderShipmentDetailLevel.IncludeProgressStatus)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(y => y.ProgressStatus);
                        }

                        if (detailLevel.OrderShipmentDetailLevel.IncludeOrderShipItems)
                        {
                            query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems);

                            if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.IncludeProgressStatus)
                            {
                                query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.ProgressStatus);
                            }

                            if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.IncludeOrderItem)
                            {
                                query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderItem);

                                if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.IncludeProduct)
                                {
                                    query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.Product);
                                }

                                if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.IncludeItemUnit)
                                {
                                    query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.ItemUnit);

                                    if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderItemDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                                    {
                                        query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderItem).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                                    }
                                }
                            }

                            if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.IncludeOrderShipItemTasks)
                            {
                                query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks);

                                if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderShipItemTaskDetailLevel.IncludeOrderShipItemStock)
                                {
                                    query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks).ThenInclude(y => y.OrderShipItemStocks);

                                    if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderShipItemTaskDetailLevel.OrderShipItemStockDetailLevel.IncludeStock)
                                    {
                                        query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks).ThenInclude(y => y.OrderShipItemStocks).ThenInclude(y => y.Stock);
                                    }

                                    if (detailLevel.OrderShipmentDetailLevel.OrderShipItemDetailLevel.OrderShipItemTaskDetailLevel.OrderShipItemStockDetailLevel.IncludeStockPackType)
                                    {
                                        query = query.Include(y => y.OrderShipments).ThenInclude(y => y.OrderShipItems).ThenInclude(y => y.OrderShipItemTasks).ThenInclude(y => y.OrderShipItemStocks).ThenInclude(y => y.Stock).ThenInclude(y => y.StockPackTypes);
                                    }
                                }
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Shipment, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdShipmentResponse>(await _shipmentRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
