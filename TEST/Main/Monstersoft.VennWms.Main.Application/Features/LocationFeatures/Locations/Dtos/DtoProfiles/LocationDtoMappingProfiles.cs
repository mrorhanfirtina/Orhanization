using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.DtoProfiles;

public class LocationDtoMappingProfiles : Profile
{
    public LocationDtoMappingProfiles()
    {
        CreateMap<Location, CreateLocationDto>().ReverseMap();
        CreateMap<Location, UpdateLocationDto>().ReverseMap();

        CreateMap<AbcCategoryList, LocationAbcCategoryResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, LocationAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<BuildingDimension, LocationBuildingDimensionResponseDto>().ReverseMap();
        CreateMap<Building, LocationBuildingResponseDto>().ReverseMap();
        CreateMap<ProductCategoryList, LocationCategoryResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, LocationDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, LocationDepositorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, LocationItemUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationLengthUnitResponseDto>().ReverseMap();
        CreateMap<LocationCodeFormat, LocationLocationCodeFormatResponseDto>().ReverseMap();
        CreateMap<LocationCoordinate, LocationLocationCoordinateResponseDto>().ReverseMap();
        CreateMap<LocationDepositor, LocationLocationDepositorResponseDto>().ReverseMap();
        CreateMap<LocationDimension, LocationLocationDimensionResponseDto>().ReverseMap();
        CreateMap<LocationFeature, LocationLocationFeatureResponseDto>().ReverseMap();
        CreateMap<LocationLockReason, LocationLocationLockReasonResponseDto>().ReverseMap();
        CreateMap<LocationPickingType, LocationLocationPickingTypeResponseDto>().ReverseMap();
        CreateMap<LocationPriority, LocationLocationPriorityResponseDto>().ReverseMap();
        CreateMap<LocationProductAbcCategory, LocationLocationProductAbcCategoryResponseDto>().ReverseMap();
        CreateMap<LocationProductAttribute, LocationLocationProductAttributeResponseDto>().ReverseMap();
        CreateMap<LocationProductCategory, LocationLocationProductCategoryResponseDto>().ReverseMap();
        CreateMap<LocationProductConstraint, LocationLocationProductConstraintResponseDto>().ReverseMap();
        CreateMap<LocationProduct, LocationLocationProductResponseDto>().ReverseMap();
        CreateMap<LocationStockAttribute, LocationLocationStockAttributeResponseDto>().ReverseMap();
        CreateMap<LocationUnitConstraint, LocationLocationUnitConstraintResponseDto>().ReverseMap();
        CreateMap<LocationZone, LocationLocationZoneResponseDto>().ReverseMap();
        CreateMap<LockReason, LocationLockReasonResponseDto>().ReverseMap();
        CreateMap<PickingType, LocationPickingTypeResponseDto>().ReverseMap();
        CreateMap<ProductAttribute, LocationProductAttributeResponseDto>().ReverseMap();
        CreateMap<Product, LocationProductResponseDto>().ReverseMap();
        CreateMap<StockAttribute, LocationStockAttributeResponseDto>().ReverseMap();
        CreateMap<StorageSystem, LocationStorageSystemResponseDto>().ReverseMap();
        CreateMap<Unit, LocationUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, LocationWeightUnitResponseDto>().ReverseMap();
        CreateMap<Zone, LocationZoneResponseDto>().ReverseMap();
    }
}
