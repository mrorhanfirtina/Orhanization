using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants.LockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;

public class DeleteLockReasonCommand : IRequest<DeletedLockReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, 
    ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLockReasons";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, LockReasonOperationClaims.Delete];

    public int Id { get; set; }

    public class DeleteLockReasonCommandHandler : IRequestHandler<DeleteLockReasonCommand, DeletedLockReasonResponse>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;

        public DeleteLockReasonCommandHandler(ILockReasonRepository lockReasonRepository, LockReasonBusinessRules lockReasonBusinessRules)
        {
            _lockReasonRepository = lockReasonRepository;
            _lockReasonBusinessRules = lockReasonBusinessRules;
        }

        public async Task<DeletedLockReasonResponse> Handle(DeleteLockReasonCommand request, CancellationToken cancellationToken)
        {
            _lockReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LockReason lockReason = await _lockReasonRepository.GetAsync(predicate: x => x.Id == request.Id, withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _lockReasonRepository.DeleteAsync(lockReason);

            return new DeletedLockReasonResponse
            {
                Id = lockReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LockReasonMessages.RequestExecutedSuccessfully
            };
        }
    }
}


