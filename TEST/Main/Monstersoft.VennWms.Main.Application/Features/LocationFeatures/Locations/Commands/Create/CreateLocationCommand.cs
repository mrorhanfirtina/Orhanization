using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Create;

public class CreateLocationCommand : IRequest<CreatedLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocations";

    public CreateLocationDto Location { get; set; }


    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, CreatedLocationResponse>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationCommandHandler(ILocationRepository locationRepository, IMapper mapper, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
            _locationBusinessRules = locationBusinessRules;
        }

        public async Task<CreatedLocationResponse> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Location.Code)
                .CheckStorageSystemIdExistence(request.Location.StorageSystemId);

            Location location = _mapper.Map<Location>(request.Location);
            location.Id = Guid.NewGuid();
            location.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            location.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedLocationResponse>(await _locationRepository.AddAsync(location));
        }
    }

}
