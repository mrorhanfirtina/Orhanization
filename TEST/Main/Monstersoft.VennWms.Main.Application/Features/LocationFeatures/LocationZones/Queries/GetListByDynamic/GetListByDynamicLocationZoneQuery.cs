using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants.LocationZoneOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Queries.GetListByDynamic;

public class GetListByDynamicLocationZoneQuery : IRequest<GetListResponse<GetListByDynamicLocationZoneListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public LocationZonesDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicLocationZoneQueryHandler : IRequestHandler<GetListByDynamicLocationZoneQuery, GetListResponse<GetListByDynamicLocationZoneListItemDto>>
    {
        private readonly ILocationZoneRepository _locationZoneRepository;
        private readonly LocationZoneBusinessRules _locationZoneBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationZoneQueryHandler(ILocationZoneRepository locationZoneRepository, IMapper mapper, LocationZoneBusinessRules locationZoneBusinessRules)
        {
            _locationZoneRepository = locationZoneRepository;
            _locationZoneBusinessRules = locationZoneBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationZoneListItemDto>> Handle(GetListByDynamicLocationZoneQuery request, CancellationToken cancellationToken)
        {
            _locationZoneBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<LocationZone> locationZoneList = await _locationZoneRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationZoneListItemDto>>(locationZoneList);
            }
            else
            {
                Paginate<LocationZone> locationZoneList = await _locationZoneRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicLocationZoneListItemDto>>(locationZoneList);
            }
        }
    }

}

