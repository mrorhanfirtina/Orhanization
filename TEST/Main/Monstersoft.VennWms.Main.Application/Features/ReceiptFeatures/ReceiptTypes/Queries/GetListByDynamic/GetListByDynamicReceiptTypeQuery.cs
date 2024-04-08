using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants.ReceiptTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetListByDynamic;

public class GetListByDynamicReceiptTypeQuery : IRequest<GetListResponse<GetListByDynamicReceiptTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReceiptTypeQueryHandler : IRequestHandler<GetListByDynamicReceiptTypeQuery, GetListResponse<GetListByDynamicReceiptTypeListItemDto>>
    {
        private readonly IReceiptTypeRepository _receiptTypeRepository;
        private readonly ReceiptTypeBusinessRules _receiptTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptTypeQueryHandler(IReceiptTypeRepository receiptTypeRepository, IMapper mapper, ReceiptTypeBusinessRules receiptTypeBusinessRules)
        {
            _receiptTypeRepository = receiptTypeRepository;
            _receiptTypeBusinessRules = receiptTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptTypeListItemDto>> Handle(GetListByDynamicReceiptTypeQuery request, CancellationToken cancellationToken)
        {
            _receiptTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReceiptType> receiptTypeList = await _receiptTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Receipts),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiptTypeListItemDto>>(receiptTypeList);
        }
    }

}

