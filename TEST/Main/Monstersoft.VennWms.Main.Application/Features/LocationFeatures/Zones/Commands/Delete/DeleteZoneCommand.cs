using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants.ZoneOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Delete;

public class DeleteZoneCommand : IRequest<DeletedZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ZoneOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetZones";

    public Guid Id { get; set; }


    public class DeleteZoneCommandHandler : IRequestHandler<DeleteZoneCommand, DeletedZoneResponse>
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ZoneBusinessRules _zoneBusinessRules;

        public DeleteZoneCommandHandler(IZoneRepository zoneRepository, ZoneBusinessRules zoneBusinessRules)
        {
            _zoneRepository = zoneRepository;
            _zoneBusinessRules = zoneBusinessRules;
        }

        public async Task<DeletedZoneResponse> Handle(DeleteZoneCommand request, CancellationToken cancellationToken)
        {
            _zoneBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Zone zone = await _zoneRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _zoneRepository.DeleteAsync(zone);

            return new DeletedZoneResponse
            {
                Id = zone.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ZoneMessages.RequestExecutedSuccessfully
            };
        }
    }

}

