using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants.ReceiptItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Delete;

public class DeleteReceiptItemMemoCommand : IRequest<DeletedReceiptItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptItemMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItemMemos";

    public Guid Id { get; set; }


    public class DeleteReceiptItemMemoCommandHandler : IRequestHandler<DeleteReceiptItemMemoCommand, DeletedReceiptItemMemoResponse>
    {
        private readonly IReceiptItemMemoRepository _receiptItemMemoRepository;
        private readonly ReceiptItemMemoBusinessRules _receiptItemMemoBusinessRules;

        public DeleteReceiptItemMemoCommandHandler(IReceiptItemMemoRepository receiptItemMemoRepository, ReceiptItemMemoBusinessRules receiptItemMemoBusinessRules)
        {
            _receiptItemMemoRepository = receiptItemMemoRepository;
            _receiptItemMemoBusinessRules = receiptItemMemoBusinessRules;
        }

        public async Task<DeletedReceiptItemMemoResponse> Handle(DeleteReceiptItemMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptItemMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptItemMemo receiptItemMemo = await _receiptItemMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptItemMemoRepository.DeleteAsync(receiptItemMemo);

            return new DeletedReceiptItemMemoResponse
            {
                Id = receiptItemMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptItemMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}
