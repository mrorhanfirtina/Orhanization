using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;

public class CreateReceiptCommand : IRequest<CreatedReceiptResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceipts";

    public CreateReceiptDto Receipt { get; set; }
    public ReceiptsDetailLevel? DetailLevel { get; set; }


    public class CreateReceiptCommandHandler : IRequestHandler<CreateReceiptCommand, CreatedReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptBusinessRules _receiptBusinessRules;

        public CreateReceiptCommandHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<CreatedReceiptResponse> Handle(CreateReceiptCommand request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Receipt? receipt = _mapper.Map<Receipt>(request.Receipt);

            receipt.CreatedDate = DateTime.Now;
            receipt.Id = Guid.NewGuid();
            receipt.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            receipt.ReceiptMemos.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            receipt.ReceiptAttributeValues.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            receipt.ReceiptItems.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.ReceiptItemMemos?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
                x.ReceiptItmStockAttrValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
            });

            await _receiptRepository.AddAsync(receipt);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptRepository.GetAsync(predicate: x => x.Id == receipt.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptResponse>(response);
            }
            else
            {
                var response = await _receiptRepository.GetAsync(predicate: x => x.Id == receipt.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptResponse>(response);
            }
        }
    }
}
