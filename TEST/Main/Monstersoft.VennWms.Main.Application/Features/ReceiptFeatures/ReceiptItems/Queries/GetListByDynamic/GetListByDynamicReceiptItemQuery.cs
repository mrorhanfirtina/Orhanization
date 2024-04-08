using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemQuery : IRequest<GetListResponse<GetListByDynamicReceiptItemListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReceiptItemQueryHandler : IRequestHandler<GetListByDynamicReceiptItemQuery, GetListResponse<GetListByDynamicReceiptItemListItemDto>>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptItemQueryHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _receiptItemBusinessRules = receiptItemBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptItemListItemDto>> Handle(GetListByDynamicReceiptItemQuery request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReceiptItem> receiptItemList = await _receiptItemRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            include: m => m.Include(x => x.ReceiptItemMemos).Include(x => x.ReceiptItmStockAttrValues),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemListItemDto>>(receiptItemList);
        }
    }

}
