using MediatR;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants.SerialLogOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Delete;

public class DeleteSerialLogCommand : IRequest<DeletedSerialLogResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, SerialLogOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerialLogs"];

    public Guid Id { get; set; }


    public class DeleteSerialLogCommandHandler : IRequestHandler<DeleteSerialLogCommand, DeletedSerialLogResponse>
    {
        private readonly ISerialLogRepository _serialLogRepository;
        private readonly SerialLogBusinessRules _serialLogBusinessRules;

        public DeleteSerialLogCommandHandler(ISerialLogRepository serialLogRepository, SerialLogBusinessRules serialLogBusinessRules)
        {
            _serialLogRepository = serialLogRepository;
            _serialLogBusinessRules = serialLogBusinessRules;
        }

        public async Task<DeletedSerialLogResponse> Handle(DeleteSerialLogCommand request, CancellationToken cancellationToken)
        {
            _serialLogBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            SerialLog serialLog = await _serialLogRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _serialLogRepository.DeleteAsync(serialLog);

            return new DeletedSerialLogResponse
            {
                Id = serialLog.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
