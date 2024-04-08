using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Update;

public class UpdateLocationZoneCommand : IRequest<UpdatedLocationZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationZoneOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationZones";

    public UpdateLocationZoneDto LocationZone { get; set; }


    public class UpdateLocationZoneCommandHandler : IRequestHandler<UpdateLocationZoneCommand, UpdatedLocationZoneResponse>
    {
        private readonly ILocationZoneRepository _locationZoneRepository;
        private readonly LocationZoneBusinessRules _locationZoneBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationZoneCommandHandler(ILocationZoneRepository locationZoneRepository, LocationZoneBusinessRules locationZoneBusinessRules, IMapper mapper)
        {
            _locationZoneRepository = locationZoneRepository;
            _locationZoneBusinessRules = locationZoneBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationZoneResponse> Handle(UpdateLocationZoneCommand request, CancellationToken cancellationToken)
        {
            _locationZoneBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.LocationZone.Id)
            .CheckLocationIdExistence(request.LocationZone.LocationId)
            .CheckZoneIdExistence(request.LocationZone.ZoneId);

            LocationZone? currentLocationZone = await _locationZoneRepository.GetAsync(predicate: x => x.Id == request.LocationZone.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            LocationZone? locationZone = _mapper.Map(request.LocationZone, currentLocationZone);
            locationZone.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedLocationZoneResponse>(await _locationZoneRepository.UpdateAsync(locationZone));
        }
    }
}

