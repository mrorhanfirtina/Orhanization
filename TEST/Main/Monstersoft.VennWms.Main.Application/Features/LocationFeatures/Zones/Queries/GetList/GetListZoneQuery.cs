using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants.ZoneOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Queries.GetList;

public class GetListZoneQuery : IRequest<GetListResponse<GetListZoneListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListZoneQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetZones";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public ZonesDetailLevel DetailLevel { get; set; }


    public class GetListZoneQueryHandler : IRequestHandler<GetListZoneQuery, GetListResponse<GetListZoneListItemDto>>
    {
        private readonly IZoneRepository _zoneRepository;
        private readonly ZoneBusinessRules _zoneBusinessRules;
        private readonly IMapper _mapper;

        public GetListZoneQueryHandler(IZoneRepository zoneRepository, IMapper mapper, ZoneBusinessRules zoneBusinessRules)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapper;
            _zoneBusinessRules = zoneBusinessRules;
        }

        public async Task<GetListResponse<GetListZoneListItemDto>> Handle(GetListZoneQuery request, CancellationToken cancellationToken)
        {
            _zoneBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Zone> zoneList = await _zoneRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Zone> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeBuilding)
                    {
                        query = query.Include(y => y.Building);
                    }

                    var includableQuery = query as IIncludableQueryable<Zone, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListZoneListItemDto>>(zoneList);
            }
            else
            {
                Paginate<Zone> zoneList = await _zoneRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListZoneListItemDto>>(zoneList);
            }
        }
    }

}

