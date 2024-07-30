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
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants.ShipmentOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Commands.Create;

public class CreateShipmentCommand : IRequest<CreatedShipmentResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetShipments"];


    public CreateShipmentDto Shipment { get; set; }
    public ShipmentsDetailLevel? DetailLevel { get; set; }

    public class CreateShipmentCommandHandler : IRequestHandler<CreateShipmentCommand, CreatedShipmentResponse>
    {
        private readonly IShipmentRepository _shipmentRepository;
        private readonly IMapper _mapper;
        private readonly ShipmentBusinessRules _shipmentBusinessRules;

        public CreateShipmentCommandHandler(IShipmentRepository shipmentRepository, IMapper mapper, ShipmentBusinessRules shipmentBusinessRules)
        {
            _shipmentRepository = shipmentRepository;
            _mapper = mapper;
            _shipmentBusinessRules = shipmentBusinessRules;
        }

        public async Task<CreatedShipmentResponse> Handle(CreateShipmentCommand request, CancellationToken cancellationToken)
        {
            _shipmentBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Shipment? shipment = _mapper.Map<Shipment>(request.Shipment);

            shipment.CreatedDate = DateTime.Now;
            shipment.Id = Guid.NewGuid();
            shipment.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            shipment.ShipmentMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            shipment.ShipmentAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });
            await _shipmentRepository.AddAsync(shipment);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _shipmentRepository.GetAsync(predicate: x => x.Id == shipment.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentResponse>(response);
            }
            else
            {
                var response = await _shipmentRepository.GetAsync(predicate: x => x.Id == shipment.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedShipmentResponse>(response);
            }
        }
    }
}
