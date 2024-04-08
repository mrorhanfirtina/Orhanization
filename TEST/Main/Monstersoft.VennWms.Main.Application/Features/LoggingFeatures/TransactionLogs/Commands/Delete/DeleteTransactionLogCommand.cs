using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants.TransactionLogOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Delete;

public class DeleteTransactionLogCommand : IRequest<DeletedTransactionLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TransactionLogOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionLogs";

    public Guid Id { get; set; }


    public class DeleteTransactionLogCommandHandler : IRequestHandler<DeleteTransactionLogCommand, DeletedTransactionLogResponse>
    {
        private readonly ITransactionLogRepository _transactionLogRepository;
        private readonly TransactionLogBusinessRules _transactionLogBusinessRules;

        public DeleteTransactionLogCommandHandler(ITransactionLogRepository transactionLogRepository, TransactionLogBusinessRules transactionLogBusinessRules)
        {
            _transactionLogRepository = transactionLogRepository;
            _transactionLogBusinessRules = transactionLogBusinessRules;
        }

        public async Task<DeletedTransactionLogResponse> Handle(DeleteTransactionLogCommand request, CancellationToken cancellationToken)
        {
            _transactionLogBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            TransactionLog transactionLog = await _transactionLogRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _transactionLogRepository.DeleteAsync(transactionLog);

            return new DeletedTransactionLogResponse
            {
                Id = transactionLog.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = transactionLog.DepositorId,
                IsSuccess = true,
                Message = TransactionLogMessages.RequestExecutedSuccessfully
            };
        }
    }
}
