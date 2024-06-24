using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants.ReceiptItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Delete;

public class DeleteReceiptItmStockAttrValueCommand : IRequest<DeletedReceiptItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptItemStockAttrValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItmStockAttrValues";

    public Guid Id { get; set; }


    public class DeleteReceiptItmStockAttrValueCommandHandler : IRequestHandler<DeleteReceiptItmStockAttrValueCommand, DeletedReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;

        public DeleteReceiptItmStockAttrValueCommandHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
        }

        public async Task<DeletedReceiptItmStockAttrValueResponse> Handle(DeleteReceiptItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptItmStockAttrValue receiptItmStockAttrValue = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptItmStockAttrValueRepository.DeleteAsync(receiptItmStockAttrValue);

            return new DeletedReceiptItmStockAttrValueResponse
            {
                Id = receiptItmStockAttrValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptItmStockAttrValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}

