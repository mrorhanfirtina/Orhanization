using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetList;

public class GetListReceiptQuery : IRequest<GetListResponse<GetListReceiptListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListReceiptQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetReceipts";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ReceiptsDetailLevel? DetailLevel { get; set; }


    public class GetListReceiptQueryHandler : IRequestHandler<GetListReceiptQuery, GetListResponse<GetListReceiptListItemDto>>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ReceiptBusinessRules _receiptBusinessRules;
        private readonly IMapper _mapper;

        public GetListReceiptQueryHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<GetListResponse<GetListReceiptListItemDto>> Handle(GetListReceiptQuery request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Receipt> receiptList = await _receiptRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Receipt> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceiptType)
                    {
                        query = query.Include(y => y.ReceiptType);
                    }

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrder);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludeSupplier)
                    {
                        query = query.Include(y => y.Supplier);

                        var supplierDetailLevel = detailLevel.SupplierDetailLevel;

                        if (supplierDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Supplier).ThenInclude(y => y.Company);
                        }
                    }

                    if (detailLevel.IncludeReceiptAttributeValue)
                    {
                        query = query.Include(y => y.ReceiptAttributeValues);

                        var attributeDetailLevel = detailLevel.ReceiptAttributeDetailLevel;

                        if (attributeDetailLevel.ReceiptAttribute)
                        {
                            query = query.Include(y => y.ReceiptAttributeValues).ThenInclude(y => y.ReceiptAttribute);
                        }
                    }

                    if (detailLevel.IncludeReceiptMemo)
                    {
                        query = query.Include(y => y.ReceiptMemos);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        var depositorDetailLevel = detailLevel.DepositorDetailLevel;

                        if (depositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(y => y.Company);
                        }
                    }

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(y => y.ReceiptItems);

                        var itemDetailLevel = detailLevel.ReceiptItemDetailLevel;

                        if (itemDetailLevel.IncludeStatus)
                        {
                            query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.Status);
                        }

                        if (itemDetailLevel.IncludeReceiptItemMemo)
                        {
                            query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ReceiptItemMemos);
                        }

                        if (itemDetailLevel.IncludeReceiptItmStockAttrValue)
                        {
                            query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ReceiptItmStockAttrValues);

                            var stockAttrDetailLevel = itemDetailLevel.ReceiptItmStockAttrValueDetailLevel;

                            if (stockAttrDetailLevel.IncludeStockAttribute)
                            {
                                query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ReceiptItmStockAttrValues).ThenInclude(y => y.StockAttribute);

                                if (stockAttrDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                                {
                                    query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ReceiptItmStockAttrValues).ThenInclude(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                                }
                            }
                        }

                        if (itemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.Product);
                        }

                        if (itemDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ItemUnit);

                            var unitDetailLevel = itemDetailLevel.ItemUnitDetailLevel;

                            if (unitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.ReceiptItems).ThenInclude(y => y.ItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Receipt, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListReceiptListItemDto>>(receiptList);
            }
            else
            {
                Paginate<Receipt> receiptList = await _receiptRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListReceiptListItemDto>>(receiptList);
            }
        }
    }

}
