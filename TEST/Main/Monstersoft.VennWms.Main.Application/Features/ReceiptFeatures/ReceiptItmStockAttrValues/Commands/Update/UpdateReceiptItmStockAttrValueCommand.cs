using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants.ReceiptItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;

public class UpdateReceiptItmStockAttrValueCommand : IRequest<UpdatedReceiptItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptItemStockAttrValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptItmStockAttrValues"];

    public UpdateReceiptItmStockAttrValueDto ReceiptItmStockAttrValue { get; set; }
    public ReceiptItmStockAttrValuesDetailLevel? DetailLevel { get; set; }

    public class UpdateReceiptItmStockAttrValueCommandHandler : IRequestHandler<UpdateReceiptItmStockAttrValueCommand, UpdatedReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptItmStockAttrValueCommandHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules, IMapper mapper)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptItmStockAttrValueResponse> Handle(UpdateReceiptItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptItmStockAttrValue.Id)
            .CheckReceiptItemIdExistence(request.ReceiptItmStockAttrValue.ReceiptItemId)
            .CheckStockAttributeIdExistence(request.ReceiptItmStockAttrValue.StockAttributeId);

            ReceiptItmStockAttrValue? currentReceiptItmStockAttrValue = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.ReceiptItmStockAttrValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptItmStockAttrValue? receiptItmStockAttrValue = _mapper.Map(request.ReceiptItmStockAttrValue, currentReceiptItmStockAttrValue);
            receiptItmStockAttrValue.UpdatedDate = DateTime.Now;

            await _receiptItmStockAttrValueRepository.UpdateAsync(receiptItmStockAttrValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == receiptItmStockAttrValue.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItmStockAttrValueResponse>(response);
            }
            else
            {
                var response = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == receiptItmStockAttrValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItmStockAttrValueResponse>(response);
            }
        }
    }
}

