using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants.LocationUnitConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Delete;

public class DeleteLocationUnitConstraintCommand : IRequest<DeletedLocationUnitConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationUnitConstraintOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationUnitConstraints"];

    public Guid Id { get; set; }

    public class DeleteLocationUnitConstraintCommandHandler : IRequestHandler<DeleteLocationUnitConstraintCommand, DeletedLocationUnitConstraintResponse>
    {
        private readonly ILocationUnitConstraintRepository _locationUnitConstraintRepository;
        private readonly LocationUnitConstraintBusinessRules _locationUnitConstraintBusinessRules;

        public DeleteLocationUnitConstraintCommandHandler(ILocationUnitConstraintRepository locationUnitConstraintRepository, LocationUnitConstraintBusinessRules locationUnitConstraintBusinessRules)
        {
            _locationUnitConstraintRepository = locationUnitConstraintRepository;
            _locationUnitConstraintBusinessRules = locationUnitConstraintBusinessRules;
        }

        public async Task<DeletedLocationUnitConstraintResponse> Handle(DeleteLocationUnitConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationUnitConstraintBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationUnitConstraint locationUnitConstraint = await _locationUnitConstraintRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationUnitConstraintRepository.DeleteAsync(locationUnitConstraint);

            return new DeletedLocationUnitConstraintResponse
            {
                Id = locationUnitConstraint.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = Application.Rules.Messages.BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}

