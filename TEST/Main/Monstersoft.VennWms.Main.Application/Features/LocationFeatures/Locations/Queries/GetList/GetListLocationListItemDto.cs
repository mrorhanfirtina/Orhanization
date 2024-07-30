using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetList;

public class GetListLocationListItemDto
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
    public ICollection<LocationBufferLocationResponseDto>? BufferLocations { get; set; }
}
