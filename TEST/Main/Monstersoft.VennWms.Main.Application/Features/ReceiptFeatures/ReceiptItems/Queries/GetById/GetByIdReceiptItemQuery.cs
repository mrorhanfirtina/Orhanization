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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetById;

public class GetByIdReceiptItemQuery : IRequest<GetByIdReceiptItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReceiptItemsDetailLevel? DetailLevel { get; set; }


    public class GetByIdReceiptItemQueryHandler : IRequestHandler<GetByIdReceiptItemQuery, GetByIdReceiptItemResponse>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptItemQueryHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _mapper = mapper;
            _receiptItemBusinessRules = receiptItemBusinessRules;
        }

        public async Task<GetByIdReceiptItemResponse> Handle(GetByIdReceiptItemQuery request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReceiptItemResponse>(await _receiptItemRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReceiptItemResponse>(await _receiptItemRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
