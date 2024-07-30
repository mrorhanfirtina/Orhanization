using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;

public class UpdateReceiptCommand : IRequest<UpdatedReceiptResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceipts"];

    public UpdateReceiptDto Receipt { get; set; }
    public ReceiptsDetailLevel? DetailLevel { get; set; }


    public class UpdateReceiptCommandHandler : IRequestHandler<UpdateReceiptCommand, UpdatedReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptBusinessRules _receiptBusinessRules;

        public UpdateReceiptCommandHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<UpdatedReceiptResponse> Handle(UpdateReceiptCommand request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Receipt.Id);

            Receipt? currentReceipt = await _receiptRepository.GetAsync(predicate: x => x.Id == request.Receipt.Id,
            include: x => x.Include(y => y.ReceiptAttributeValues)
                           .Include(y => y.ReceiptMemos)
                           .Include(y => y.ReceiptItems)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItemMemos)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Receipt? receipt = _mapper.Map(request.Receipt, currentReceipt);
            receipt.UpdatedDate = DateTime.Now;

            receipt.ReceiptItems.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = receipt.CreatedDate;

                x.ReceiptItemMemos?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
                x.ReceiptItmStockAttrValues?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
            });

            receipt.ReceiptAttributeValues?.ToList().ForEach(x => { x.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
            receipt.ReceiptMemos?.ToList().ForEach(x => { x.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });

            await _receiptRepository.UpdateAsync(receipt);

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

                return _mapper.Map<UpdatedReceiptResponse>(response);
            }
            else
            {
                var response = await _receiptRepository.GetAsync(predicate: x => x.Id == receipt.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptResponse>(response);
            }
        }
    }
}
