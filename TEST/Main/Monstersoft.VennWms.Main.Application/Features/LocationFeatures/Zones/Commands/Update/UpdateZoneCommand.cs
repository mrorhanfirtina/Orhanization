using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Update;

public class UpdateZoneCommand : IRequest<UpdatedZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ZoneOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetZones";

    public UpdateZoneDto Zone { get; set; }


    public class UpdateZoneCommandHandler : IRequestHandler<UpdateZoneCommand, UpdatedZoneResponse>
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ZoneBusinessRules _zoneBusinessRules;
        private readonly IMapper _mapper;

        public UpdateZoneCommandHandler(IZoneRepository zoneRepository, ZoneBusinessRules zoneBusinessRules, IMapper mapper)
        {
            _zoneRepository = zoneRepository;
            _zoneBusinessRules = zoneBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedZoneResponse> Handle(UpdateZoneCommand request, CancellationToken cancellationToken)
        {
            _zoneBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Zone.Id)
            .CheckCodeExistenceWhenUpdate(request.Zone.Code, request.Zone.Id)
            .CheckBuildingIdExistence(request.Zone.BuildingId);

            Zone? currentZone = await _zoneRepository.GetAsync(predicate: x => x.Id == request.Zone.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Zone? zone = _mapper.Map(request.Zone, currentZone);
            zone.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedZoneResponse>(await _zoneRepository.UpdateAsync(zone));
        }
    }
}

