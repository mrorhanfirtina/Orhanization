using AutoMapper;
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
    public BuildingDetailLevel DetailLevel { get; set; }


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

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Building> buildingList = await _buildingRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
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
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBuildingListItemDto>>(buildingList);
            }
            else
            {
                Paginate<Building> buildingList = await _buildingRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBuildingListItemDto>>(buildingList);
            }
        }
    }

}

