using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetListByDynamic;

public class GetListByDynamicLocationQuery : IRequest<GetListResponse<GetListByDynamicLocationListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLocationQueryHandler : IRequestHandler<GetListByDynamicLocationQuery, GetListResponse<GetListByDynamicLocationListItemDto>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLocationQueryHandler(ILocationRepository locationRepository, IMapper mapper, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _locationBusinessRules = locationBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLocationListItemDto>> Handle(GetListByDynamicLocationQuery request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Location> locationList = await _locationRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLocationListItemDto>>(locationList);
        }
    }

}
