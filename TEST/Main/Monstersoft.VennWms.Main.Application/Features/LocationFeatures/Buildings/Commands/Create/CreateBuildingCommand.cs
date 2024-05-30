using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;

public class CreateBuildingCommand : IRequest<CreatedBuildingResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBuildings";

    public CreateBuildingDto Building { get; set; }
    public BuildingsDetailLevel DetailLevel { get; set; }

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
            building.BuildingDimension.CreatedDate = DateTime.Now;

            await _buildingRepository.AddAsync(building);

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

                return _mapper.Map<CreatedBuildingResponse>(response);
            }
            else
            {
                var response = await _buildingRepository.GetAsync(predicate: x => x.Id == building.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBuildingResponse>(response);
            }
        }
    }
}

