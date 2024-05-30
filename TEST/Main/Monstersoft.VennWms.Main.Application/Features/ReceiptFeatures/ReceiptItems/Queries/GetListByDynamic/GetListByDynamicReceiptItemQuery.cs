using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemQuery : IRequest<GetListResponse<GetListByDynamicReceiptItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReceiptItemsDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReceiptItemQueryHandler : IRequestHandler<GetListByDynamicReceiptItemQuery, GetListResponse<GetListByDynamicReceiptItemListItemDto>>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptItemQueryHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _receiptItemBusinessRules = receiptItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptItemListItemDto>> Handle(GetListByDynamicReceiptItemQuery request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReceiptItem> receiptItemList = await _receiptItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReceiptItem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceiptItemMemo)
                    {
                        query = query.Include(y => y.ReceiptItemMemos);
                    }

                    if (detailLevel.IncludeReceiptItmStockAttrValue)
                    {
                        query = query.Include(y => y.ReceiptItmStockAttrValues);

                        var stockAttrDetailLevel = detailLevel.ReceiptItmStockAttrValueDetailLevel;

                        if (stockAttrDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.ReceiptItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                            if (stockAttrDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.ReceiptItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
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

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipt);
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptItem, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemListItemDto>>(receiptItemList);
            }
            else
            {
                Paginate<ReceiptItem> receiptItemList = await _receiptItemRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemListItemDto>>(receiptItemList);
            }
        }
    }

}
