using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants.ReceiptMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetListByDynamic;

public class GetListByDynamicReceiptMemoQuery : IRequest<GetListResponse<GetListByDynamicReceiptMemoListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReceiptMemoQueryHandler : IRequestHandler<GetListByDynamicReceiptMemoQuery, GetListResponse<GetListByDynamicReceiptMemoListItemDto>>
    {
        private readonly IReceiptMemoRepository _receiptMemoRepository;
        private readonly ReceiptMemoBusinessRules _receiptMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptMemoQueryHandler(IReceiptMemoRepository receiptMemoRepository, IMapper mapper, ReceiptMemoBusinessRules receiptMemoBusinessRules)
        {
            _receiptMemoRepository = receiptMemoRepository;
            _receiptMemoBusinessRules = receiptMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptMemoListItemDto>> Handle(GetListByDynamicReceiptMemoQuery request, CancellationToken cancellationToken)
        {
            _receiptMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReceiptMemo> receiptMemoList = await _receiptMemoRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiptMemoListItemDto>>(receiptMemoList);
        }
    }

}
