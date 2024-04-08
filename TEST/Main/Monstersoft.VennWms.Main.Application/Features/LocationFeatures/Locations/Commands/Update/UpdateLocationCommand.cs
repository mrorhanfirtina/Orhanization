using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Update;

public class UpdateLocationCommand : IRequest<UpdatedLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocations";

    public UpdateLocationDto Location { get; set; }


    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, UpdatedLocationResponse>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationCommandHandler(ILocationRepository locationRepository, LocationBusinessRules locationBusinessRules, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _locationBusinessRules = locationBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationResponse> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Location.Id)
            .CheckCodeExistenceWhenUpdate(request.Location.Code, request.Location.Id)
            .CheckStorageSystemIdExistence(request.Location.StorageSystemId);

            Location? currentLocation = await _locationRepository.GetAsync(predicate: x => x.Id == request.Location.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Location? location = _mapper.Map(request.Location, currentLocation);
            location.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedLocationResponse>(await _locationRepository.UpdateAsync(location));
        }
    }
}
