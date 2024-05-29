﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetList;

public class GetListLocationQuery : IRequest<GetListResponse<GetListLocationListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListLocationQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetLocations";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }
    public LocationDetailLevel DetailLevel { get; set; }


    public class GetListLocationQueryHandler : IRequestHandler<GetListLocationQuery, GetListResponse<GetListLocationListItemDto>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public GetListLocationQueryHandler(ILocationRepository locationRepository, IMapper mapper, LocationBusinessRules locationBusinessRules)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
            _locationBusinessRules = locationBusinessRules;
        }

        public async Task<GetListResponse<GetListLocationListItemDto>> Handle(GetListLocationQuery request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<Location> locationList = await _locationRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<Location> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeStorageSystem)
                    {
                        query = query.Include(y => y.StorageSystem);
                    }

                    if (detailLevel.IncludeLocationLockReason)
                    {
                        query = query.Include(y => y.LocationLockReason);

                        if (detailLevel.LocationLockReasonDetailLevel.IncludeLockReason)
                        {
                            query = query.Include(y => y.LocationLockReason).ThenInclude(m => m.LockReason);
                        }
                    }

                    if (detailLevel.IncludeLocationPickingType)
                    {
                        query = query.Include(y => y.LocationPickingType);

                        if (detailLevel.LocationPickingTypeDetailLevel.IncludePickingType)
                        {
                            query = query.Include(y => y.LocationPickingType).ThenInclude(m => m.PickingType);
                        }
                    }

                    if (detailLevel.IncludeLocationDimension)
                    {
                        query = query.Include(y => y.LocationDimension);

                        if (detailLevel.LocationDimensionDetailLevel.IncludeLengthUnit)
                        {
                            query = query.Include(y => y.LocationDimension).ThenInclude(m => m.LengthUnit);
                        }

                        if (detailLevel.LocationDimensionDetailLevel.IncludeVolumeUnit)
                        {
                            query = query.Include(y => y.LocationDimension).ThenInclude(m => m.VolumeUnit);
                        }

                        if (detailLevel.LocationDimensionDetailLevel.IncludeWeightUnit)
                        {
                            query = query.Include(y => y.LocationDimension).ThenInclude(m => m.WeightUnit);
                        }
                    }

                    if (detailLevel.IncludeLocationFeature)
                    {
                        query = query.Include(y => y.LocationFeature);
                    }

                    if (detailLevel.IncludeLocationPriority)
                    {
                        query = query.Include(y => y.LocationPriority);
                    }

                    if (detailLevel.IncludeLocationCodeFormat)
                    {
                        query = query.Include(y => y.LocationCodeFormat);
                    }

                    if (detailLevel.IncludeLocationCoordinate)
                    {
                        query = query.Include(y => y.LocationCoordinate);

                        if (detailLevel.LocationCoordinateDetailLevel.IncludeBuilding)
                        {
                            query = query.Include(y => y.LocationCoordinate).ThenInclude(m => m.Building);

                            if (detailLevel.LocationCoordinateDetailLevel.BuildingDetailLevel.IncludeBuildingDimension)
                            {
                                query = query.Include(y => y.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(l => l.BuildingDimension);

                                if (detailLevel.LocationCoordinateDetailLevel.BuildingDetailLevel.BuildingDimensionDetailLevel.IncludeLengthUnit)
                                {
                                    query = query.Include(y => y.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(l => l.BuildingDimension).ThenInclude(b => b.LenghtUnitId);
                                }

                                if (detailLevel.LocationCoordinateDetailLevel.BuildingDetailLevel.BuildingDimensionDetailLevel.IncludeVolumeUnit)
                                {
                                    query = query.Include(y => y.LocationCoordinate).ThenInclude(m => m.Building).ThenInclude(l => l.BuildingDimension).ThenInclude(b => b.VolumeUnit);
                                }
                            }
                        }
                    }

                    if (detailLevel.IncludeLocationZone)
                    {
                        query = query.Include(y => y.LocationZones);

                        if (detailLevel.LocationZoneDetailLevel.IncludeZone)
                        {
                            query = query.Include(y => y.LocationZones).ThenInclude(m => m.Zone);
                        }
                    }

                    if (detailLevel.IncludeLocationUnitConstraint)
                    {
                        query = query.Include(y => y.LocationUnitConstraints);

                        if (detailLevel.LocationUnitConstraintDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.LocationUnitConstraints).ThenInclude(m => m.Unit);
                        }
                    }

                    if (detailLevel.IncludeLocationProductCategory)
                    {
                        query = query.Include(y => y.LocationProductCategories);

                        if (detailLevel.LocationProductCategoryDetailLevel.IncludeCategory)
                        {
                            query = query.Include(y => y.LocationProductCategories).ThenInclude(m => m.Category);
                        }
                    }

                    if (detailLevel.IncludeLocationProductAbcCategory)
                    {
                        query = query.Include(y => y.LocationProductAbcCategories);

                        if (detailLevel.LocationProductAbcCategoryDetailLevel.IncludeAbcCategory)
                        {
                            query = query.Include(y => y.LocationProductAbcCategories).ThenInclude(m => m.AbcCategory);
                        }
                    }

                    if (detailLevel.IncludeLocationProductConstraint)
                    {
                        query = query.Include(y => y.LocationProductConstraints);

                        if (detailLevel.LocationProductConstraintDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(y => y.LocationProductConstraints).ThenInclude(m => m.ItemUnit);

                            if (detailLevel.LocationProductConstraintDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.LocationProductConstraints).ThenInclude(m => m.ItemUnit).ThenInclude(y => y.Unit);
                            }

                            if (detailLevel.LocationProductConstraintDetailLevel.ItemUnitDetailLevel.IncludeProduct)
                            {
                                query = query.Include(y => y.LocationProductConstraints).ThenInclude(m => m.ItemUnit).ThenInclude(y => y.Product);
                            }
                        }
                    }

                    if (detailLevel.IncludeLocationDepositor)
                    {
                        query = query.Include(y => y.LocationDepositors);

                        if (detailLevel.LocationDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.LocationDepositors).ThenInclude(m => m.Depositor);
                        }
                    }

                    if (detailLevel.IncludeLocationProduct)
                    {
                        query = query.Include(y => y.LocationProducts);

                        if (detailLevel.LocationProductDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.LocationProducts).ThenInclude(m => m.Product);
                        }
                    }

                    if (detailLevel.IncludeLocationStockAttribute)
                    {
                        query = query.Include(y => y.LocationStockAttributes);

                        if (detailLevel.LocationStockAttributeDetailLevel.IncludeStockAttribute)
                        {
                            query = query.Include(y => y.LocationStockAttributes).ThenInclude(m => m.StockAttribute);

                            if (detailLevel.LocationStockAttributeDetailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.LocationStockAttributes).ThenInclude(m => m.StockAttribute).ThenInclude(y => y.AttributeInputType);
                            }
                        }
                    }

                    if (detailLevel.IncludeLocationProductAttribute)
                    {
                        query = query.Include(y => y.LocationProductAttributes);


                        if (detailLevel.LocationProductAttributeDetailLevel.IncludeProductAttribute)
                        {
                            query = query.Include(y => y.LocationProductAttributes).ThenInclude(m => m.ProductAttribute);

                            if (detailLevel.LocationProductAttributeDetailLevel.ProductAttributeDetailLevel.IncludeAttributeInputType)
                            {
                                query = query.Include(y => y.LocationProductAttributes).ThenInclude(m => m.ProductAttribute).ThenInclude(l => l.AttributeInputType);
                            }
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Location, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListLocationListItemDto>>(locationList);
            }
            else
            {
                Paginate<Location> locationList = await _locationRepository.GetListAsync(
                predicate: m => m.DepositorCompanyId == depositorCompanyId,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListLocationListItemDto>>(locationList);
            }
        }
    }

}
