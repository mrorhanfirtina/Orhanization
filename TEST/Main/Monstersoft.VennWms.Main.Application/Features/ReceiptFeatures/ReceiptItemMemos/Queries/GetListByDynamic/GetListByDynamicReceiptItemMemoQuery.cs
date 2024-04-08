using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants.ReceiptItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemMemoQuery : IRequest<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


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

            Paginate<ReceiptItemMemo> receiptItemMemoList = await _receiptItemMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiptItemMemoListItemDto>>(receiptItemMemoList);
        }
    }
}
