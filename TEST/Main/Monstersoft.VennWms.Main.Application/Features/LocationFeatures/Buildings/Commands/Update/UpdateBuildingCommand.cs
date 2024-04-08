using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Update;

public class UpdateBuildingCommand : IRequest<UpdatedBuildingResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, BuildingOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBuildings";

    public UpdateBuildingDto Building { get; set; }


    public class UpdateBuildingCommandHandler : IRequestHandler<UpdateBuildingCommand, UpdatedBuildingResponse>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBuildingCommandHandler(IBuildingRepository buildingRepository, BuildingBusinessRules buildingBusinessRules, IMapper mapper)
        {
            _buildingRepository = buildingRepository;
            _buildingBusinessRules = buildingBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedBuildingResponse> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Building.Id)
            .CheckCodeExistenceWhenUpdate(request.Building.Code, request.Building.Id)
            .CheckSiteIdExistence(request.Building.SiteId);

            Building? currentBuilding = await _buildingRepository.GetAsync(predicate: x => x.Id == request.Building.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Building? building = _mapper.Map(request.Building, currentBuilding);
            building.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedBuildingResponse>(await _buildingRepository.UpdateAsync(building));
        }
    }
}

