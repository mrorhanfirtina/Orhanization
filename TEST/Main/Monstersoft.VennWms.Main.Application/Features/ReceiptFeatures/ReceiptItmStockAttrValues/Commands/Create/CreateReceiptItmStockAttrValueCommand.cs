using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;

public class CreateReceiptItmStockAttrValueCommand : IRequest<CreatedReceiptItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptItmStockAttrValues"];


    public CreateReceiptItmStockAttrValueDto ReceiptItmStockAttrValue { get; set; }
    public ReceiptItmStockAttrValuesDetailLevel? DetailLevel { get; set; }


    public class CreateReceiptItmStockAttrValueCommandHandler : IRequestHandler<CreateReceiptItmStockAttrValueCommand, CreatedReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptItmStockAttrValueCommandHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, IMapper mapper, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _mapper = mapper;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
        }

        public async Task<CreatedReceiptItmStockAttrValueResponse> Handle(CreateReceiptItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReceiptItemIdExistence(request.ReceiptItmStockAttrValue.ReceiptItemId)
                .CheckStockAttributeIdExistence(request.ReceiptItmStockAttrValue.StockAttributeId);

            ReceiptItmStockAttrValue receiptItmStockAttrValue = _mapper.Map<ReceiptItmStockAttrValue>(request.ReceiptItmStockAttrValue);
            receiptItmStockAttrValue.Id = Guid.NewGuid();
            receiptItmStockAttrValue.CreatedDate = DateTime.Now;

            await _receiptItmStockAttrValueRepository.AddAsync(receiptItmStockAttrValue);

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

                return _mapper.Map<CreatedReceiptItmStockAttrValueResponse>(response);
            }
            else
            {
                var response = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == receiptItmStockAttrValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptItmStockAttrValueResponse>(response);
            }
        }
    }
}

