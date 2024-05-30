using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Queries.GetById;

public class GetByIdOrderShipItemQuery : IRequest<GetByIdOrderShipItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderShipItemsDetailLevel? DetailLevel { get; set; }


    public class GetByIdOrderShipItemQueryHandler : IRequestHandler<GetByIdOrderShipItemQuery, GetByIdOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderShipItemQueryHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _mapper = mapper;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<GetByIdOrderShipItemResponse> Handle(GetByIdOrderShipItemQuery request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderShipItemResponse>(await _orderShipItemRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderShipItemResponse>(await _orderShipItemRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
