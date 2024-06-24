using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants.LocationLockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Commands.Delete;

public class DeleteLocationLockReasonCommand : IRequest<DeletedLocationLockReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationLockReasonOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationLockReasons";

    public Guid Id { get; set; }

    public class DeleteLocationLockReasonCommandHandler : IRequestHandler<DeleteLocationLockReasonCommand, DeletedLocationLockReasonResponse>
    {
        private readonly ILocationLockReasonRepository _locationLockReasonRepository;
        private readonly LocationLockReasonBusinessRules _locationLockReasonBusinessRules;

        public DeleteLocationLockReasonCommandHandler(ILocationLockReasonRepository locationLockReasonRepository, LocationLockReasonBusinessRules locationLockReasonBusinessRules)
        {
            _locationLockReasonRepository = locationLockReasonRepository;
            _locationLockReasonBusinessRules = locationLockReasonBusinessRules;
        }

        public async Task<DeletedLocationLockReasonResponse> Handle(DeleteLocationLockReasonCommand request, CancellationToken cancellationToken)
        {
            _locationLockReasonBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationLockReason locationLockReason = await _locationLockReasonRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationLockReasonRepository.DeleteAsync(locationLockReason);

            return new DeletedLocationLockReasonResponse
            {
                Id = locationLockReason.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = Application.Rules.Messages.BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}


