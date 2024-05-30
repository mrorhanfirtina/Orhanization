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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetListByDynamic;

public class GetListByDynamicOrderItemQuery : IRequest<GetListResponse<GetListByDynamicOrderItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public OrderItemsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicOrderItemQueryHandler : IRequestHandler<GetListByDynamicOrderItemQuery, GetListResponse<GetListByDynamicOrderItemListItemDto>>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicOrderItemQueryHandler(IOrderItemRepository orderItemRepository, IMapper mapper, OrderItemBusinessRules orderItemBusinessRules)
        {
            _orderItemRepository = orderItemRepository;
            _orderItemBusinessRules = orderItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicOrderItemListItemDto>> Handle(GetListByDynamicOrderItemQuery request, CancellationToken cancellationToken)
        {
            _orderItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<OrderItem> orderItemList = await _orderItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderItemListItemDto>>(orderItemList);
            }
            else
            {
                Paginate<OrderItem> orderItemList = await _orderItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicOrderItemListItemDto>>(orderItemList);
            }
        }
    }

}
