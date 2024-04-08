using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
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

            Paginate<LocationZone> locationZoneList = await _locationZoneRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLocationZoneListItemDto>>(locationZoneList);
        }
    }

}

