using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetByCode;

public class GetByCodeReceiptQuery : IRequest<GetByCodeReceiptResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeReceiptQueryHandler : IRequestHandler<GetByCodeReceiptQuery, GetByCodeReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ReceiptBusinessRules _receiptBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReceiptQueryHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<GetByCodeReceiptResponse> Handle(GetByCodeReceiptQuery request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReceiptResponse>(await _receiptRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.ReceiptAttributeValues).Include(x => x.ReceiptMemos)
            .Include(x => x.ReceiptItems).ThenInclude(ri => ri.ReceiptItemMemos)
            .Include(x => x.ReceiptItems).ThenInclude(ri => ri.ReceiptItmStockAttrValues),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
