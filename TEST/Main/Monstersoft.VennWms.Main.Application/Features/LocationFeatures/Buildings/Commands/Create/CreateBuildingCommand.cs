using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants.BuildingOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;

public class CreateBuildingCommand : IRequest<CreatedBuildingResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBuildings";

    public CreateBuildingDto Building { get; set; }


    public class CreateBuildingCommandHandler : IRequestHandler<CreateBuildingCommand, CreatedBuildingResponse>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;
        private readonly IMapper _mapper;

        public CreateBuildingCommandHandler(IBuildingRepository buildingRepository, IMapper mapper, BuildingBusinessRules buildingBusinessRules)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
            _buildingBusinessRules = buildingBusinessRules;
        }

        public async Task<CreatedBuildingResponse> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Building.Code)
                .CheckSiteIdExistence(request.Building.SiteId);

            Building building = _mapper.Map<Building>(request.Building);
            building.Id = Guid.NewGuid();
            building.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            building.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedBuildingResponse>(await _buildingRepository.AddAsync(building));
        }
    }
}

