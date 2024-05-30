using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Update;

public class UpdateReceiptItemCommand : IRequest<UpdatedReceiptItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItems";

    public UpdateReceiptItemDto ReceiptItem { get; set; }
    public ReceiptItemsDetailLevel? DetailLevel { get; set; }


    public class UpdateReceiptItemCommandHandler : IRequestHandler<UpdateReceiptItemCommand, UpdatedReceiptItemResponse>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;

        public UpdateReceiptItemCommandHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _mapper = mapper;
            _receiptItemBusinessRules = receiptItemBusinessRules;
        }

        public async Task<UpdatedReceiptItemResponse> Handle(UpdateReceiptItemCommand request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptItem.Id);

            ReceiptItem? currentReceiptItem = await _receiptItemRepository.GetAsync(predicate: x => x.Id == request.ReceiptItem.Id,
            include: x => x.Include(y => y.ReceiptItemMemos)
            .Include(y => y.ReceiptItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptItem? receiptItem = _mapper.Map(request.ReceiptItem, currentReceiptItem);
            receiptItem.UpdatedDate = DateTime.Now;

            receiptItem.ReceiptItemMemos?.ToList().ForEach(x => { x.CreatedDate = receiptItem.CreatedDate; x.UpdatedDate = DateTime.Now; });
            receiptItem.ReceiptItmStockAttrValues?.ToList().ForEach(x => { x.CreatedDate = receiptItem.CreatedDate; x.UpdatedDate = DateTime.Now; });

            await _receiptItemRepository.UpdateAsync(receiptItem);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptItemRepository.GetAsync(predicate: x => x.Id == receiptItem.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItemResponse>(response);
            }
            else
            {
                var response = await _receiptItemRepository.GetAsync(predicate: x => x.Id == receiptItem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItemResponse>(response);
            }
        }
    }
}
