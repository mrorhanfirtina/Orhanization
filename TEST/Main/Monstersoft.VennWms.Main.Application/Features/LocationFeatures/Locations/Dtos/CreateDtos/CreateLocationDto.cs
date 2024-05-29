using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.CreateDtos;

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
    public ICollection<CreateLocationStockAttributeSubDto>? LocationStockAttributes { get; set; }
    public ICollection<CreateLocationZoneSubDto>? LocationZones { get; set; }
    public ICollection<CreateLocationProductSubDto>? Products { get; set; }
    public ICollection<CreateLocationProductAttributeSubDto>? LocationProductAttributes { get; set; }
    public ICollection<CreateLocationProductCategorySubDto>? LocationProductCategories { get; set; }
    public ICollection<CreateLocationProductAbcCategorySubDto>? LocationProductAbcCategories { get; set; }
}

