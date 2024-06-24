using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants.ReceiptItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemMemoQuery : IRequest<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReceiptItemMemosDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReceiptItemMemoQueryHandler : IRequestHandler<GetListByDynamicReceiptItemMemoQuery, GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>
    {
        private readonly IReceiptItemMemoRepository _receiptItemMemoRepository;
        private readonly ReceiptItemMemoBusinessRules _receiptItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptItemMemoQueryHandler(IReceiptItemMemoRepository receiptItemMemoRepository, IMapper mapper, ReceiptItemMemoBusinessRules receiptItemMemoBusinessRules)
        {
            _receiptItemMemoRepository = receiptItemMemoRepository;
            _receiptItemMemoBusinessRules = receiptItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>> Handle(GetListByDynamicReceiptItemMemoQuery request, CancellationToken cancellationToken)
        {
            _receiptItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReceiptItemMemo> receiptItemMemoList = await _receiptItemMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReceiptItemMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(y => y.ReceiptItem);

                        if (detailLevel.ReceiptItemDetailLevel.IncludeReceipt)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Receipt);
                        }

                        if (detailLevel.ReceiptItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptItemMemo, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>(receiptItemMemoList);
            }
            else
            {
                Paginate<ReceiptItemMemo> receiptItemMemoList = await _receiptItemMemoRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>(receiptItemMemoList);
            }
        }
    }
}
