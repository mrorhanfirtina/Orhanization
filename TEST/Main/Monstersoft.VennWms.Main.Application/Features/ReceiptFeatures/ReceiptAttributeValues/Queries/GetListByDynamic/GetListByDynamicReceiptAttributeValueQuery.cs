using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants.ReceiptAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicReceiptAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReceiptAttributeValueQueryHandler : IRequestHandler<GetListByDynamicReceiptAttributeValueQuery, GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>
    {
        private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
        private readonly ReceiptAttributeValueBusinessRules _receiptAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptAttributeValueQueryHandler(IReceiptAttributeValueRepository receiptAttributeValueRepository, IMapper mapper, ReceiptAttributeValueBusinessRules receiptAttributeValueBusinessRules)
        {
            _receiptAttributeValueRepository = receiptAttributeValueRepository;
            _receiptAttributeValueBusinessRules = receiptAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>> Handle(GetListByDynamicReceiptAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _receiptAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReceiptAttributeValue> receiptAttributeValueList = await _receiptAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>(receiptAttributeValueList);
        }
    }

}
