using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants.ReceiptItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItmStockAttrValueQuery : IRequest<GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReceiptItmStockAttrValuesDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReceiptItmStockAttrValueQueryHandler : IRequestHandler<GetListByDynamicReceiptItmStockAttrValueQuery, GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptItmStockAttrValueQueryHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, IMapper mapper, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>> Handle(GetListByDynamicReceiptItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReceiptItmStockAttrValue> receiptItmStockAttrValueList = await _receiptItmStockAttrValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReceiptItmStockAttrValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        var stockAttrDetailLevel = detailLevel.StockAttributeDetailLevel;

                        if (stockAttrDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(y => y.ReceiptItem);

                        var receiptItemDetailLevel = detailLevel.ReceiptItemDetailLevel;

                        if (receiptItemDetailLevel.IncludeReceipt)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Receipt);
                        }

                        if (receiptItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptItmStockAttrValue, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>>(receiptItmStockAttrValueList);
            }
            else
            {
                Paginate<ReceiptItmStockAttrValue> receiptItmStockAttrValueList = await _receiptItmStockAttrValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItmStockAttrValueListItemDto>>(receiptItmStockAttrValueList);
            }
        }
    }
}

