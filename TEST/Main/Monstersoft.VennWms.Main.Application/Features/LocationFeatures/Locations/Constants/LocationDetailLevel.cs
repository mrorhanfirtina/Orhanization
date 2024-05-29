using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants.LocationDetailLevel.LocationLocationProductConstraintDetailLevel;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;

public class LocationDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeStorageSystem { get; set; } = false;
    public bool IncludeLocationLockReason { get; set; } = false;
    public bool IncludeLocationPickingType { get; set; } = false;
    public bool IncludeLocationDimension { get; set; } = false;
    public bool IncludeLocationFeature { get; set; } = false;
    public bool IncludeLocationPriority { get; set; } = false;
    public bool IncludeLocationCodeFormat { get; set; } = false;
    public bool IncludeLocationCoordinate { get; set; } = false;
    public bool IncludeLocationZone { get; set; } = false;
    public bool IncludeLocationUnitConstraint { get; set; } = false;
    public bool IncludeLocationProductCategory { get; set; } = false;
    public bool IncludeLocationProductAbcCategory { get; set; } = false;
    public bool IncludeLocationProductConstraint { get; set; } = false;
    public bool IncludeLocationDepositor { get; set; } = false;
    public bool IncludeLocationProduct { get; set; } = false;
    public bool IncludeLocationStockAttribute { get; set; } = false;
    public bool IncludeLocationProductAttribute { get; set; } = false;
    public LocationLocationCoordinateDetailLevel LocationCoordinateDetailLevel { get; set; } = new LocationLocationCoordinateDetailLevel();
    public class LocationLocationCoordinateDetailLevel
    {
        public bool IncludeBuilding { get; set; } = false;
        public LocationBuildingDetailLevel BuildingDetailLevel { get; set; } = new LocationBuildingDetailLevel();

        public class LocationBuildingDetailLevel
        {
            public bool IncludeBuildingDimension { get; set; } = false;
            public LocationBuildingDimensionDetailLevel BuildingDimensionDetailLevel { get; set; } = new LocationBuildingDimensionDetailLevel();

            public class LocationBuildingDimensionDetailLevel
            {
                public bool IncludeLengthUnit { get; set; } = false;
                public bool IncludeVolumeUnit { get; set; } = false;
            }
        }
    }
    public LocationLocationDepositorDetailLevel LocationDepositorDetailLevel { get; set; } = new LocationLocationDepositorDetailLevel();
    public class LocationLocationDepositorDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;
    }
    public LocationLocationDimensionDetailLevel LocationDimensionDetailLevel { get; set; } = new LocationLocationDimensionDetailLevel();
    public class LocationLocationDimensionDetailLevel
    {
        public bool IncludeLengthUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
        public bool IncludeWeightUnit { get; set; } = false;
    }
    public LocationLocationLockReasonDetailLevel LocationLockReasonDetailLevel { get; set; } = new LocationLocationLockReasonDetailLevel();
    public class LocationLocationLockReasonDetailLevel
    {
        public bool IncludeLockReason { get; set; } = false;
    }
    public LocationLocationPickingTypeDetailLevel LocationPickingTypeDetailLevel { get; set; } = new LocationLocationPickingTypeDetailLevel();
    public class LocationLocationPickingTypeDetailLevel
    {
        public bool IncludePickingType { get; set; } = false;
    }
    public LocationLocationProductDetailLevel LocationProductDetailLevel { get; set; } = new LocationLocationProductDetailLevel();
    public class LocationLocationProductDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
    }
    public LocationLocationProductAbcCategoryDetailLevel LocationProductAbcCategoryDetailLevel { get; set; } = new LocationLocationProductAbcCategoryDetailLevel();
    public class LocationLocationProductAbcCategoryDetailLevel
    {
        public bool IncludeAbcCategory { get; set; } = false;
    }
    public LocationLocationProductAttributeDetailLevel LocationProductAttributeDetailLevel { get; set; } = new LocationLocationProductAttributeDetailLevel();

    public class LocationLocationProductAttributeDetailLevel
    {
        public bool IncludeProductAttribute { get; set; } = false;

        public LocProductAttributeDetailLevel ProductAttributeDetailLevel { get; set; } = new LocProductAttributeDetailLevel();

        public class LocProductAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public LocationLocationProductCategoryDetailLevel LocationProductCategoryDetailLevel { get; set; } = new LocationLocationProductCategoryDetailLevel();
    public class LocationLocationProductCategoryDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }
    public LocationLocationProductConstraintDetailLevel LocationProductConstraintDetailLevel { get; set; } = new LocationLocationProductConstraintDetailLevel();
    public class LocationLocationProductConstraintDetailLevel
    {
        public bool IncludeItemUnit { get; set; } = false;
        public LocationItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new LocationItemUnitDetailLevel();

        public class LocationItemUnitDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeUnit { get; set; } = false;
        }
    }
    public LocationLocationStockAttributeDetailLevel LocationStockAttributeDetailLevel { get; set; } = new LocationLocationStockAttributeDetailLevel();
    public class LocationLocationStockAttributeDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public LocationStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new LocationStockAttributeDetailLevel();

        public class LocationStockAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public LocationLocationUnitConstraintDetailLevel LocationUnitConstraintDetailLevel { get; set; } = new LocationLocationUnitConstraintDetailLevel();
    public class LocationLocationUnitConstraintDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }

    public LocationLocationZoneDetailLevel LocationZoneDetailLevel { get; set; } = new LocationLocationZoneDetailLevel();
    public class LocationLocationZoneDetailLevel
    {
        public bool IncludeZone { get; set; } = false;
    }
}
