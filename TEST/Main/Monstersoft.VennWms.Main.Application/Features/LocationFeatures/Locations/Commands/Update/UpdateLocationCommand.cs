using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.UpdateDtos;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Update;

public class UpdateLocationCommand : IRequest<UpdatedLocationResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, LocationOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocations"];

    public UpdateLocationDto Location { get; set; }
    public LocationsDetailLevel DetailLevel { get; set; }


    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, UpdatedLocationResponse>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly LocationBusinessRules _locationBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLocationCommandHandler(ILocationRepository locationRepository, LocationBusinessRules locationBusinessRules, IMapper mapper)
        {
            _locationRepository = locationRepository;
            _locationBusinessRules = locationBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLocationResponse> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            _locationBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Location.Id)
            .CheckCodeExistenceWhenUpdate(request.Location.Code, request.Location.Id)
            .CheckStorageSystemIdExistence(request.Location.StorageSystemId);

            Location? currentLocation = await _locationRepository.GetAsync(predicate: x => x.Id == request.Location.Id,
                include: x => x.Include(y => y.LocationPickingType)
                .Include(y => y.LocationFeature).Include(y => y.LocationPriority).Include(y => y.LocationDimension)
                .Include(y => y.LocationCoordinate).Include(y => y.LocationCodeFormat).Include(y => y.LocationZones)
                .Include(y => y.LocationUnitConstraints).Include(y => y.LocationProductConstraints).Include(y => y.LocationDepositors)
                .Include(y => y.LocationStockAttributes).Include(y => y.LocationProductAttributes).Include(y => y.LocationProducts)
                .Include(y => y.LocationLockReason).Include(y => y.LocationProductCategories).Include(y => y.LocationProductAbcCategories)
                );

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Location? location = _mapper.Map(request.Location, currentLocation);
            location.UpdatedDate = DateTime.Now;

            if (location.LocationPickingType != null)
            {
                location.LocationPickingType.CreatedDate = location.CreatedDate;
                location.LocationPickingType.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationFeature != null)
            {
                location.LocationFeature.CreatedDate = location.CreatedDate;
                location.LocationFeature.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationPriority != null)
            {
                location.LocationPriority.CreatedDate = location.CreatedDate;
                location.LocationPriority.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationDimension != null)
            {
                location.LocationDimension.CreatedDate = location.CreatedDate;
                location.LocationDimension.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationLockReason != null)
            {
                location.LocationLockReason.CreatedDate = location.CreatedDate;
                location.LocationLockReason.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationCodeFormat != null)
            {
                location.LocationCodeFormat.CreatedDate = location.CreatedDate;
                location.LocationCodeFormat.UpdatedDate = DateTime.Now;
            }
                
            if (location.LocationCoordinate != null)
            {
                location.LocationCoordinate.CreatedDate = location.CreatedDate;
                location.LocationCoordinate.UpdatedDate = DateTime.Now;
            }
                

            location.LocationZones?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationProducts?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationDepositors?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationStockAttributes?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationUnitConstraints?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationProductAttributes?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationProductConstraints?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationProductCategories?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });
            location.LocationProductAbcCategories?.ToList().ForEach(x => { x.CreatedDate = location.CreatedDate; x.UpdatedDate = DateTime.Now; });

            await _locationRepository.UpdateAsync(location);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _locationRepository.GetAsync(predicate: x => x.Id == location.Id,
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

                    if (detailLevel.IncludeBufferLocation)
                    {
                        query = query.Include(y => y.BufferLocations);

                        if (detailLevel.BufferLocationDetailLevel.IncludeBuffLocation)
                        {
                            query = query.Include(y => y.BufferLocations).ThenInclude(m => m.BuffLocation);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Location, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationResponse>(response);
            }
            else
            {
                var response = await _locationRepository.GetAsync(predicate: x => x.Id == location.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedLocationResponse>(response);
            }
        }
    }
}
