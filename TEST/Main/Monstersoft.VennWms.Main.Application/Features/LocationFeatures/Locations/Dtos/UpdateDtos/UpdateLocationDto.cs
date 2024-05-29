using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.UpdateDtos;

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
    public ICollection<UpdateLocationStockAttributeSubDto>? LocationStockAttributes { get; set; }
    public ICollection<UpdateLocationZoneSubDto>? LocationZones { get; set; }
    public ICollection<UpdateLocationProductSubDto>? Products { get; set; }
    public ICollection<UpdateLocationProductAttributeSubDto>? LocationProductAttributes { get; set; }
    public ICollection<UpdateLocationProductCategorySubDto>? LocationProductCategories { get; set; }
    public ICollection<UpdateLocationProductAbcCategorySubDto>? LocationProductAbcCategories { get; set; }
}

