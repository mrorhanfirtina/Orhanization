using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public BuildingDetailLevel DetailLevel { get; set; }


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

            Building? currentBuilding = await _buildingRepository.GetAsync(predicate: x => x.Id == request.Building.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.BuildingDimension)
            .Include(y => y.Site).Include(y => y.DepositorCompany)
            .Include(y => y.BuildingDimension).ThenInclude( p => p.LenghtUnit)
            .Include(y => y.BuildingDimension).ThenInclude( p => p.VolumeUnit)
            );

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Building? building = _mapper.Map(request.Building, currentBuilding);
            building.UpdatedDate = DateTime.Now;
            building.BuildingDimension.UpdatedDate = DateTime.Now;

            await _buildingRepository.UpdateAsync(building);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _buildingRepository.GetAsync(predicate: x => x.Id == building.Id,
                include: x =>
                {
                    IQueryable<Building> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeSite)
                    {
                        query = query.Include(y => y.Site);

                        if (detailLevel.SiteDetailLevel.IncludeSiteDepositor)
                        {
                            query = query.Include(y => y.Site).ThenInclude(m => m.SiteDepositors);

                            if (detailLevel.SiteDetailLevel.DepositorDetailLevel.IncludeDepositor)
                            {
                                query = query.Include(y => y.Site).ThenInclude(m => m.SiteDepositors).ThenInclude(m => m.Depositor);
                            }
                        }
                    }

                    if (detailLevel.IncludeBuildingDimension)
                    {
                        query = query.Include(y => y.BuildingDimension);

                        if (detailLevel.BuildingDimensionDetailLevel.IncludeLenghtUnit)
                        {
                            query = query.Include(y => y.BuildingDimension).ThenInclude(m => m.LenghtUnitId);
                        }

                        if (detailLevel.BuildingDimensionDetailLevel.IncludeVolumeUnit)
                        {
                            query = query.Include(y => y.BuildingDimension).ThenInclude(m => m.VolumeUnit);
                        }
                    }

                    if (detailLevel.IncludeStorageSystem)
                    {
                        query = query.Include(y => y.StorageSystems);
                    }

                    if (detailLevel.IncludeZone)
                    {
                        query = query.Include(y => y.Zones);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<Building, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBuildingResponse>(response);
            }
            else
            {
                var response = await _buildingRepository.GetAsync(predicate: x => x.Id == building.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedBuildingResponse>(response);
            }
        }
    }
}

