using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Delete;

public class DeleteTransactionTypeCommand : IRequest<DeletedTransactionTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TaskCodeFormatOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionTypes";

    public int Id { get; set; }


    public class DeleteTransactionTypeCommandHandler : IRequestHandler<DeleteTransactionTypeCommand, DeletedTransactionTypeResponse>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;

        public DeleteTransactionTypeCommandHandler(ITransactionTypeRepository transactionTypeRepository, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
        }

        public async Task<DeletedTransactionTypeResponse> Handle(DeleteTransactionTypeCommand request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            TransactionType transactionType = await _transactionTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _transactionTypeRepository.DeleteAsync(transactionType);

            return new DeletedTransactionTypeResponse
            {
                Id = transactionType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = TransactionTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

