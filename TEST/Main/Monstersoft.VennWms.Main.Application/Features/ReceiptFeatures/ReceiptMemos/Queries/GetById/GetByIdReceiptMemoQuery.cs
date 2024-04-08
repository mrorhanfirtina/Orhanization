using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants.ReceiptMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Queries.GetById;

public class GetByIdReceiptMemoQuery : IRequest<GetByIdReceiptMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReceiptMemoQueryHandler : IRequestHandler<GetByIdReceiptMemoQuery, GetByIdReceiptMemoResponse>
    {
        private readonly IReceiptMemoRepository _receiptMemoRepository;
        private readonly ReceiptMemoBusinessRules _receiptMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptMemoQueryHandler(IReceiptMemoRepository receiptMemoRepository, IMapper mapper, ReceiptMemoBusinessRules receiptMemoBusinessRules)
        {
            _receiptMemoRepository = receiptMemoRepository;
            _mapper = mapper;
            _receiptMemoBusinessRules = receiptMemoBusinessRules;
        }

        public async Task<GetByIdReceiptMemoResponse> Handle(GetByIdReceiptMemoQuery request, CancellationToken cancellationToken)
        {
            _receiptMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReceiptMemoResponse>(await _receiptMemoRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
