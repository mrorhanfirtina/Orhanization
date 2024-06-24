using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetListByDynamic;

public class GetListByDynamicReturnItemQuery : IRequest<GetListResponse<GetListByDynamicReturnItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReturnItemsDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReturnItemQueryHandler : IRequestHandler<GetListByDynamicReturnItemQuery, GetListResponse<GetListByDynamicReturnItemListItemDto>>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnItemQueryHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _returnItemBusinessRules = returnItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnItemListItemDto>> Handle(GetListByDynamicReturnItemQuery request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReturnItem> returnItemList = await _returnItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReturnItem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeReturnItemMemo)
                    {
                        query = query.Include(y => y.ReturnItemMemos);
                    }

                    if (detailLevel.IncludeReturnItmStockAttrValue)
                    {
                        query = query.Include(y => y.ReturnItmStockAttrValues);

                        var returnItmStockAttrValueDetailLevel = detailLevel.ReturnItmStockAttrValueDetailLevel;

                        if (returnItmStockAttrValueDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                            var stockAttributeDetailLevel = returnItmStockAttrValueDetailLevel.StockAttributeDetailLevel;

                            if (stockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ReturnItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);

                        var itemUnitDetailLevel = detailLevel.ItemUnitDetailLevel;

                        if (itemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(y => y.Unit);
                        }
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnItem, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReturnItemListItemDto>>(returnItemList);
            }
            else
            {
                Paginate<ReturnItem> returnItemList = await _returnItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReturnItemListItemDto>>(returnItemList);
            }
        }
    }

}
