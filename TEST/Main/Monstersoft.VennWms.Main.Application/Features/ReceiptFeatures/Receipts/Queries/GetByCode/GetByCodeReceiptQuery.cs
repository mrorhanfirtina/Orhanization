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
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetByCode;

public class GetByCodeReceiptQuery : IRequest<GetByCodeReceiptResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public ReceiptsDetailLevel? DetailLevel { get; set; }


    public class GetByCodeReceiptQueryHandler : IRequestHandler<GetByCodeReceiptQuery, GetByCodeReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ReceiptBusinessRules _receiptBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReceiptQueryHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<GetByCodeReceiptResponse> Handle(GetByCodeReceiptQuery request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeReceiptResponse>(await _receiptRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeReceiptResponse>(await _receiptRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
