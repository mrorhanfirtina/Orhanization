using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Delete;

public class DeleteReceiptCommand : IRequest<DeletedReceiptResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceipts";

    public Guid Id { get; set; }


    public class DeleteReceiptCommandHandler : IRequestHandler<DeleteReceiptCommand, DeletedReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly ReceiptBusinessRules _receiptBusinessRules;

        public DeleteReceiptCommandHandler(IReceiptRepository receiptRepository, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<DeletedReceiptResponse> Handle(DeleteReceiptCommand request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Receipt receipt = await _receiptRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptRepository.DeleteAsync(receipt);

            return new DeletedReceiptResponse
            {
                Id = receipt.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = receipt.DepositorId,
                IsSuccess = true,
                Message = ReceiptMessages.RequestExecutedSuccessfully
            };
        }
    }
}
