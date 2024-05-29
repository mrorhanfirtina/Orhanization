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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetById;

public class GetByIdReceiptQuery : IRequest<GetByIdReceiptResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReceiptQueryHandler : IRequestHandler<GetByIdReceiptQuery, GetByIdReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ReceiptBusinessRules _receiptBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptQueryHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<GetByIdReceiptResponse> Handle(GetByIdReceiptQuery request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReceiptResponse>(await _receiptRepository.GetAsync(x => x.Id == request.Id,
                include: x => x.Include(y => y.ReceiptAttributeValues)
                           .Include(y => y.ReceiptMemos)
                           .Include(y => y.ReceiptItems)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItemMemos)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItmStockAttrValues),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
