using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants.LocationZoneOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Delete;

public class DeleteLocationZoneCommand : IRequest<DeletedLocationZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, LocationZoneOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationZones"];

    public Guid Id { get; set; }


    public class DeleteLocationZoneCommandHandler : IRequestHandler<DeleteLocationZoneCommand, DeletedLocationZoneResponse>
    {
        private readonly ILocationZoneRepository _locationZoneRepository;
        private readonly LocationZoneBusinessRules _locationZoneBusinessRules;

        public DeleteLocationZoneCommandHandler(ILocationZoneRepository locationZoneRepository, LocationZoneBusinessRules locationZoneBusinessRules)
        {
            _locationZoneRepository = locationZoneRepository;
            _locationZoneBusinessRules = locationZoneBusinessRules;
        }

        public async Task<DeletedLocationZoneResponse> Handle(DeleteLocationZoneCommand request, CancellationToken cancellationToken)
        {
            _locationZoneBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationZone locationZone = await _locationZoneRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationZoneRepository.DeleteAsync(locationZone);

            return new DeletedLocationZoneResponse
            {
                Id = locationZone.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = LocationZoneMessages.RequestExecutedSuccessfully
            };
        }
    }

}

