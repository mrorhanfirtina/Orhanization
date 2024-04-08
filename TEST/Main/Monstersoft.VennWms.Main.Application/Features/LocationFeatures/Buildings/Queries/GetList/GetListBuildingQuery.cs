using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants.BuildingOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetList;

public class GetListBuildingQuery : IRequest<GetListResponse<GetListBuildingListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListBuildingQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetBuildings";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListBuildingQueryHandler : IRequestHandler<GetListBuildingQuery, GetListResponse<GetListBuildingListItemDto>>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;
        private readonly IMapper _mapper;

        public GetListBuildingQueryHandler(IBuildingRepository buildingRepository, IMapper mapper, BuildingBusinessRules buildingBusinessRules)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
            _buildingBusinessRules = buildingBusinessRules;
        }

        public async Task<GetListResponse<GetListBuildingListItemDto>> Handle(GetListBuildingQuery request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Building> buildingList = await _buildingRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListBuildingListItemDto>>(buildingList);
        }
    }

}

