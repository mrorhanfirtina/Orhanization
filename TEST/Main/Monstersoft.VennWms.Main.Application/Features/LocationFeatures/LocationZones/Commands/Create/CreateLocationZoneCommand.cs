using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants.LocationZoneOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Create;

public class CreateLocationZoneCommand : IRequest<CreatedLocationZoneResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLocationZones";

    public CreateLocationZoneDto LocationZone { get; set; }
    public LocationZonesDetailLevel DetailLevel { get; set; }


    public class CreateLocationZoneCommandHandler : IRequestHandler<CreateLocationZoneCommand, CreatedLocationZoneResponse>
    {
        private readonly ILocationZoneRepository _locationZoneRepository;
        private readonly LocationZoneBusinessRules _locationZoneBusinessRules;
        private readonly IMapper _mapper;

        public CreateLocationZoneCommandHandler(ILocationZoneRepository locationZoneRepository, IMapper mapper, LocationZoneBusinessRules locationZoneBusinessRules)
        {
            _locationZoneRepository = locationZoneRepository;
            _mapper = mapper;
            _locationZoneBusinessRules = locationZoneBusinessRules;
        }

        public async Task<CreatedLocationZoneResponse> Handle(CreateLocationZoneCommand request, CancellationToken cancellationToken)
        {
            _locationZoneBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckLocationIdExistence(request.LocationZone.LocationId)
                .CheckZoneIdExistence(request.LocationZone.ZoneId);

            LocationZone locationZone = _mapper.Map<LocationZone>(request.LocationZone);
            locationZone.Id = Guid.NewGuid();
            locationZone.CreatedDate = DateTime.Now;

            await _locationZoneRepository.AddAsync(locationZone);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationZoneRepository.GetAsync(predicate: x => x.Id == locationZone.Id,
                include: x =>
                {
                    IQueryable<LocationZone> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Location);
                    }

                    if (detailLevel.IncludeZone)
                    {
                        query = query.Include(y => y.Zone);
                    }


                    var includableQuery = query as IIncludableQueryable<LocationZone, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationZoneResponse>(response);
            }
            else
            {
                var response = await _locationZoneRepository.GetAsync(predicate: x => x.Id == locationZone.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedLocationZoneResponse>(response);
            }
        }
    }

}

