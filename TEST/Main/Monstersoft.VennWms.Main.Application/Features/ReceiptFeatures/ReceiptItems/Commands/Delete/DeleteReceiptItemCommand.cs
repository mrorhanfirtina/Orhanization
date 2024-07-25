using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Delete;

public class DeleteReceiptItemCommand : IRequest<DeletedReceiptItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptItemOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptItems"];

    public Guid Id { get; set; }


    public class DeleteReceiptItemCommandHandler : IRequestHandler<DeleteReceiptItemCommand, DeletedReceiptItemResponse>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;

        public DeleteReceiptItemCommandHandler(IReceiptItemRepository receiptItemRepository, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _receiptItemBusinessRules = receiptItemBusinessRules;
        }

        public async Task<DeletedReceiptItemResponse> Handle(DeleteReceiptItemCommand request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptItem receiptItem = await _receiptItemRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.ReceiptItemMemos)
            .Include(y => y.ReceiptItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _receiptItemRepository.DeleteAsync(receiptItem);

            return new DeletedReceiptItemResponse
            {
                Id = receiptItem.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptItemMessages.RequestExecutedSuccessfully
            };
        }
    }
}
