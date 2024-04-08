using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants.ReceiptTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Delete;

public class DeleteReceiptTypeCommand : IRequest<DeletedReceiptTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiptTypeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptTypes";

    public Guid Id { get; set; }


    public class DeleteReceiptTypeCommandHandler : IRequestHandler<DeleteReceiptTypeCommand, DeletedReceiptTypeResponse>
    {
        private readonly IReceiptTypeRepository _receiptTypeRepository;
        private readonly ReceiptTypeBusinessRules _receiptTypeBusinessRules;

        public DeleteReceiptTypeCommandHandler(IReceiptTypeRepository receiptTypeRepository, ReceiptTypeBusinessRules receiptTypeBusinessRules)
        {
            _receiptTypeRepository = receiptTypeRepository;
            _receiptTypeBusinessRules = receiptTypeBusinessRules;
        }

        public async Task<DeletedReceiptTypeResponse> Handle(DeleteReceiptTypeCommand request, CancellationToken cancellationToken)
        {
            _receiptTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ReceiptType receiptType = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiptTypeRepository.DeleteAsync(receiptType);

            return new DeletedReceiptTypeResponse
            {
                Id = receiptType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiptTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

