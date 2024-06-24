using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants.ReceiptMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Delete;

public class DeleteReceiptMemoCommand : IRequest<DeletedReceiptMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptMemos";

    public Guid Id { get; set; }


    public class DeleteReceiptMemoCommandHandler : IRequestHandler<DeleteReceiptMemoCommand, DeletedReceiptMemoResponse>
    {
        private readonly IReceiptMemoRepository _receiptMemoRepository;
        private readonly ReceiptMemoBusinessRules _receiptMemoBusinessRules;

        public DeleteReceiptMemoCommandHandler(IReceiptMemoRepository receiptMemoRepository, ReceiptMemoBusinessRules receiptMemoBusinessRules)
        {
            _receiptMemoRepository = receiptMemoRepository;
            _receiptMemoBusinessRules = receiptMemoBusinessRules;
        }

        public async Task<DeletedReceiptMemoResponse> Handle(DeleteReceiptMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptMemo receiptMemo = await _receiptMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptMemoRepository.DeleteAsync(receiptMemo);

            return new DeletedReceiptMemoResponse
            {
                Id = receiptMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}
