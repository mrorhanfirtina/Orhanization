using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public virtual CreateLocationLockReasonSubDto? LocationLockReason { get; set; }
    public virtual CreateLocationPickingTypeSubDto? LocationPickingType { get; set; }
    public virtual CreateLocationDimensionSubDto? LocationDimension { get; set; }
    public virtual CreateLocationFeatureSubDto? LocationFeature { get; set; }
    public virtual CreateLocationPrioritySubDto? LocationPriority { get; set; }
    public virtual CreateLocationCodeFormatSubDto? LocationCodeFormat { get; set; }
    public virtual CreateLocationCoordinateSubDto? LocationCoordinate { get; set; }
    public virtual ICollection<CreateLocationUnitConstraintSubDto>? LocationUnitConstraints { get; set; }
    public virtual ICollection<CreateLocationProductConstraintSubDto>? LocationProductConstraints { get; set; }
    public virtual ICollection<CreateLocationDepositorSubDto>? LocationDepositors { get; set; }
    public ICollection<CreateLocationStockAttributeSubDto> LocationStockAttributes { get; set; }
    public ICollection<CreateLocationZoneSubDto> LocationZones { get; set; }
    public ICollection<CreateLocationProductSubDto> Products { get; set; }
    public ICollection<CreateLocationProductAttributeSubDto> LocationProductAttributes { get; set; }
}

