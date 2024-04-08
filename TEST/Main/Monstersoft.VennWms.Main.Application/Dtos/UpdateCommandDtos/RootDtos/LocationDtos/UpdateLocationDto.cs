using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public virtual UpdateLocationLockReasonSubDto? LocationLockReason { get; set; }
    public virtual UpdateLocationPickingTypeSubDto? LocationPickingType { get; set; }
    public virtual UpdateLocationDimensionSubDto? LocationDimension { get; set; }
    public virtual UpdateLocationFeatureSubDto? LocationFeature { get; set; }
    public virtual UpdateLocationPrioritySubDto? LocationPriority { get; set; }
    public virtual UpdateLocationCodeFormatSubDto? LocationCodeFormat { get; set; }
    public virtual UpdateLocationCoordinateSubDto? LocationCoordinate { get; set; }
    public virtual ICollection<UpdateLocationUnitConstraintSubDto>? LocationUnitConstraints { get; set; }
    public virtual ICollection<UpdateLocationProductConstraintSubDto>? LocationProductConstraints { get; set; }
    public virtual ICollection<UpdateLocationDepositorSubDto>? LocationDepositors { get; set; }
    public ICollection<UpdateLocationStockAttributeSubDto> LocationStockAttributes { get; set; }
    public ICollection<UpdateLocationZoneSubDto> LocationZones { get; set; }
    public ICollection<UpdateLocationProductSubDto> Products { get; set; }
    public ICollection<UpdateLocationProductAttributeSubDto> LocationProductAttributes { get; set; }
}

