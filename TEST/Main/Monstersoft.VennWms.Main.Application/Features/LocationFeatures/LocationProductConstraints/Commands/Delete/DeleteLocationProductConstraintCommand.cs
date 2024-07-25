using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants.LocationProductConstraintOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Delete;

public class DeleteLocationProductConstraintCommand : IRequest<DeletedLocationProductConstraintResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationProductConstraintOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationProductConstraints"];

    public Guid Id { get; set; }

    public class DeleteLocationProductConstraintCommandHandler : IRequestHandler<DeleteLocationProductConstraintCommand, DeletedLocationProductConstraintResponse>
    {
        private readonly ILocationProductConstraintRepository _locationProductConstraintRepository;
        private readonly LocationProductConstraintBusinessRules _locationProductConstraintBusinessRules;

        public DeleteLocationProductConstraintCommandHandler(ILocationProductConstraintRepository locationProductConstraintRepository, LocationProductConstraintBusinessRules locationProductConstraintBusinessRules)
        {
            _locationProductConstraintRepository = locationProductConstraintRepository;
            _locationProductConstraintBusinessRules = locationProductConstraintBusinessRules;
        }

        public async Task<DeletedLocationProductConstraintResponse> Handle(DeleteLocationProductConstraintCommand request, CancellationToken cancellationToken)
        {
            _locationProductConstraintBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationProductConstraint locationProductConstraint = await _locationProductConstraintRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationProductConstraintRepository.DeleteAsync(locationProductConstraint);

            return new DeletedLocationProductConstraintResponse
            {
                Id = locationProductConstraint.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationProductConstraintMessages.RequestExecutedSuccessfully
            };
        }
    }
}

