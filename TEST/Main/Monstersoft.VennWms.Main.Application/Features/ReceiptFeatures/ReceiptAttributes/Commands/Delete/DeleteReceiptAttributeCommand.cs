using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants.ReceiptAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Delete;

public class DeleteReceiptAttributeCommand : IRequest<DeletedReceiptAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptAttributeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptAttributes";

    public Guid Id { get; set; }


    public class DeleteReceiptAttributeCommandHandler : IRequestHandler<DeleteReceiptAttributeCommand, DeletedReceiptAttributeResponse>
    {
        private readonly IReceiptAttributeRepository _receiptAttributeRepository;
        private readonly ReceiptAttributeBusinessRules _receiptAttributeBusinessRules;

        public DeleteReceiptAttributeCommandHandler(IReceiptAttributeRepository receiptAttributeRepository, ReceiptAttributeBusinessRules receiptAttributeBusinessRules)
        {
            _receiptAttributeRepository = receiptAttributeRepository;
            _receiptAttributeBusinessRules = receiptAttributeBusinessRules;
        }

        public async Task<DeletedReceiptAttributeResponse> Handle(DeleteReceiptAttributeCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptAttribute receiptAttribute = await _receiptAttributeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptAttributeRepository.DeleteAsync(receiptAttribute);

            return new DeletedReceiptAttributeResponse
            {
                Id = receiptAttribute.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptAttributeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

