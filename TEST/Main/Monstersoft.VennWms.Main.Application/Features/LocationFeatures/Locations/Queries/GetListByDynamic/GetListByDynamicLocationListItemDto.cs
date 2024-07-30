using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetListByDynamic;

public class GetListByDynamicLocationListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public LocationStorageSystemResponseDto? StorageSystem { get; set; }
    public LocationLocationLockReasonResponseDto? LocationLockReason { get; set; }
    public LocationLocationPickingTypeResponseDto? LocationPickingType { get; set; }
    public LocationLocationDimensionResponseDto? LocationDimension { get; set; }
    public LocationLocationFeatureResponseDto? LocationFeature { get; set; }
    public LocationLocationPriorityResponseDto? LocationPriority { get; set; }
    public LocationLocationCodeFormatResponseDto? LocationCodeFormat { get; set; }
    public LocationLocationCoordinateResponseDto? LocationCoordinate { get; set; }
    public ICollection<LocationLocationZoneResponseDto>? LocationZones { get; set; }
    public ICollection<LocationLocationUnitConstraintResponseDto>? LocationUnitConstraints { get; set; }
    public ICollection<LocationLocationProductCategoryResponseDto>? LocationProductCategories { get; set; }
    public ICollection<LocationLocationProductAbcCategoryResponseDto>? LocationProductAbcCategories { get; set; }
    public ICollection<LocationLocationProductConstraintResponseDto>? LocationProductConstraints { get; set; }
    public ICollection<LocationLocationDepositorResponseDto>? LocationDepositors { get; set; }
    public ICollection<LocationLocationProductResponseDto>? LocationProducts { get; set; }
    public ICollection<LocationLocationStockAttributeResponseDto>? LocationStockAttributes { get; set; }
    public ICollection<LocationLocationProductAttributeResponseDto>? LocationProductAttributes { get; set; }
    public ICollection<LocationBufferLocationResponseDto>? BufferLocations { get; set; }

}
