using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Create;

public class CreateZoneCommand : IRequest<CreatedZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetZones";

    public CreateZoneDto Zone { get; set; }


    public class CreateZoneCommandHandler : IRequestHandler<CreateZoneCommand, CreatedZoneResponse>
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ZoneBusinessRules _zoneBusinessRules;
        private readonly IMapper _mapper;

        public CreateZoneCommandHandler(IZoneRepository zoneRepository, IMapper mapper, ZoneBusinessRules zoneBusinessRules)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapper;
            _zoneBusinessRules = zoneBusinessRules;
        }

        public async Task<CreatedZoneResponse> Handle(CreateZoneCommand request, CancellationToken cancellationToken)
        {
            _zoneBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckBuildingIdExistence(request.Zone.BuildingId)
                .CheckCodeExistenceWhenCreate(request.Zone.Code);

            Zone zone = _mapper.Map<Zone>(request.Zone);
            zone.Id = Guid.NewGuid();
            zone.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            zone.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedZoneResponse>(await _zoneRepository.AddAsync(zone));
        }
    }

}

