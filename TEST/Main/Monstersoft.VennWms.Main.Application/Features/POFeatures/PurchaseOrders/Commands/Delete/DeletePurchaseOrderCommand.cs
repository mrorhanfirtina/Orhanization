using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants.PurchaseOrderOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Delete;

public class DeletePurchaseOrderCommand : IRequest<DeletedPurchaseOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, PurchaseOrderOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPurchaseOrders";

    public Guid Id { get; set; }


    public class DeletePurchaseOrderCommandHandler : IRequestHandler<DeletePurchaseOrderCommand, DeletedPurchaseOrderResponse>
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        private readonly PurchaseOrderBusinessRules _purchaseOrderBusinessRules;

        public DeletePurchaseOrderCommandHandler(IPurchaseOrderRepository purchaseOrderRepository, PurchaseOrderBusinessRules purchaseOrderBusinessRules)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
            _purchaseOrderBusinessRules = purchaseOrderBusinessRules;
        }

        public async Task<DeletedPurchaseOrderResponse> Handle(DeletePurchaseOrderCommand request, CancellationToken cancellationToken)
        {
            _purchaseOrderBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            PurchaseOrder purchaseOrder = await _purchaseOrderRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.PoMemos)
                           .Include(y => y.PoAttributeValues)
                           .Include(y => y.Receipts)
                           .Include(y => y.Receipts).ThenInclude(z => z.ReceiptAttributeValues)
                           .Include(y => y.Receipts).ThenInclude(z => z.ReceiptMemos)
                           .Include(y => y.Receipts).ThenInclude(z => z.ReceiptItems)
                           .Include(y => y.Receipts).ThenInclude(z => z.ReceiptItems).ThenInclude(a => a.ReceiptItemMemos)
                           .Include(y => y.Receipts).ThenInclude(z => z.ReceiptItems).ThenInclude(a => a.ReceiptItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _purchaseOrderRepository.DeleteAsync(purchaseOrder);

            return new DeletedPurchaseOrderResponse
            {
                Id = purchaseOrder.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = purchaseOrder.DepositorId,
                IsSuccess = true,
                Message = PurchaseOrderMessages.RequestExecutedSuccessfully
            };
        }
    }
}
