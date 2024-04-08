using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants.BuildingOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetListByDynamic;

public class GetListByDynamicBuildingQuery : IRequest<GetListResponse<GetListByDynamicBuildingListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicBuildingQueryHandler : IRequestHandler<GetListByDynamicBuildingQuery, GetListResponse<GetListByDynamicBuildingListItemDto>>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBuildingQueryHandler(IBuildingRepository buildingRepository, IMapper mapper, BuildingBusinessRules buildingBusinessRules)
        {
            _buildingRepository = buildingRepository;
            _buildingBusinessRules = buildingBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBuildingListItemDto>> Handle(GetListByDynamicBuildingQuery request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Building> buildingList = await _buildingRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicBuildingListItemDto>>(buildingList);
        }
    }

}

