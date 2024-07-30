using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetList;

public class GetListLocationQuery : IRequest<GetListResponse<GetListLocationListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListLocationQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetLocations";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public LocationsDetailLevel DetailLevel { get; set; }


    public class GetListLocationQueryHandler : IRequestHandler<GetListLocationQuery, GetListResponse<GetListLocationListItemDto>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public GetListLocationQueryHandler(ILocationRepository locationRepository, IMapper mapper, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
            _locationBusinessRules = locationBusinessRules;
        }

        public async Task<GetListResponse<GetListLocationListItemDto>> Handle(GetListLocationQuery request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Location> locationList = await _locationRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x => x.Include(l => l.DepositorCompany)
                               .Include(l => l.StorageSystem)
                               .Include(l => l.LocationLockReason)
                               .Include(l => l.LocationLockReason).ThenInclude(m => m.LockReason)
                               .Include(l => l.LocationPickingType)
                               .Include(l => l.LocationPickingType).ThenInclude(m => m.PickingType)
                               .Include(l => l.LocationDimension)
                               .Include(l => l.LocationDimension).ThenInclude(m => m.VolumeUnitId)
                               .Include(l => l.LocationDimension).ThenInclude(m => m.WeightUnitId)
                               .Include(l => l.LocationDimension).ThenInclude(m => m.LengthUnit)
                               .Include(l => l.LocationFeature)
                               .Include(l => l.LocationPriority)
                               .Include(l => l.LocationCodeFormat)
                               .Include(l => l.BufferLocations)
                               .Include(l => l.BufferLocations).ThenInclude(m => m.BuffLocation)
                               .Include(l => l.LocationCoordinate).ThenInclude(m => m.Building)
                               .Include(l => l.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(g => g.BuildingDimension)
                               .Include(l => l.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(g => g.BuildingDimension).ThenInclude(v => v.VolumeUnit)
                               .Include(l => l.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(g => g.BuildingDimension).ThenInclude(v => v.LenghtUnit),
                orderBy: x => x.OrderByDescending(m => m.CreatedDate),
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListLocationListItemDto>>(locationList);
        }
    }

}
