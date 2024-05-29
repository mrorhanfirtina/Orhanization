using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetById;

public class GetByIdOrderItemQuery : IRequest<GetByIdOrderItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderItemDetailLevel DetailLevel { get; set; }


    public class GetByIdOrderItemQueryHandler : IRequestHandler<GetByIdOrderItemQuery, GetByIdOrderItemResponse>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
            _orderItemBusinessRules = orderItemBusinessRules;
        }

        public async Task<GetByIdOrderItemResponse> Handle(GetByIdOrderItemQuery request, CancellationToken cancellationToken)
        {
            _orderItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderItemResponse>(await _orderItemRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderItemResponse>(await _orderItemRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
