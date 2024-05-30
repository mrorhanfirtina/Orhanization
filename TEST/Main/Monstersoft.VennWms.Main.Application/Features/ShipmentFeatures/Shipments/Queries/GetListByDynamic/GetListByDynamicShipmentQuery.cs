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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Queries.GetListByDynamic;

public class GetListByDynamicShipmentQuery : IRequest<GetListResponse<GetListByDynamicShipmentListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ShipmentsDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicShipmentQueryHandler : IRequestHandler<GetListByDynamicShipmentQuery, GetListResponse<GetListByDynamicShipmentListItemDto>>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicShipmentQueryHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _shipmentBusinessRules = shipmentBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicShipmentListItemDto>> Handle(GetListByDynamicShipmentQuery request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Shipment> shipmentList = await _shipmentRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentListItemDto>>(shipmentList);
            }
            else
            {
                Paginate<Shipment> shipmentList = await _shipmentRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicShipmentListItemDto>>(shipmentList);
            }
        }
    }
}
