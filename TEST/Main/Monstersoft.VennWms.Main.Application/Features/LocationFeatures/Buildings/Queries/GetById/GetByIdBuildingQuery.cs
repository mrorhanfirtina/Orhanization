﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants.BuildingOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetById;

public class GetByIdBuildingQuery : IRequest<GetByIdBuildingResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public BuildingDetailLevel DetailLevel { get; set; }


    public class GetByIdBuildingQueryHandler : IRequestHandler<GetByIdBuildingQuery, GetByIdBuildingResponse>
    {
        private readonly IBuildingRepository _buildingRepository;
        private readonly BuildingBusinessRules _buildingBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBuildingQueryHandler(IBuildingRepository buildingRepository, IMapper mapper, BuildingBusinessRules buildingBusinessRules)
        {
            _buildingRepository = buildingRepository;
            _mapper = mapper;
            _buildingBusinessRules = buildingBusinessRules;
        }

        public async Task<GetByIdBuildingResponse> Handle(GetByIdBuildingQuery request, CancellationToken cancellationToken)
        {
            _buildingBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdBuildingResponse>(await _buildingRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBuildingResponse>(await _buildingRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

