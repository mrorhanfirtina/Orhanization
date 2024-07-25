namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;

public class LocationsDetailLevel
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
    public LocationsLocationCoordinateSubDetailLevel LocationCoordinateDetailLevel { get; set; } = new LocationsLocationCoordinateSubDetailLevel();
    public class LocationsLocationCoordinateSubDetailLevel
    {
        public bool IncludeBuilding { get; set; } = false;
        public LocationsBuildingSubDetailLevel BuildingDetailLevel { get; set; } = new LocationsBuildingSubDetailLevel();

        public class LocationsBuildingSubDetailLevel
        {
            public bool IncludeBuildingDimension { get; set; } = false;
            public LocationsBuildingDimensionSubDetailLevel BuildingDimensionDetailLevel { get; set; } = new LocationsBuildingDimensionSubDetailLevel();

            public class LocationsBuildingDimensionSubDetailLevel
            {
                public bool IncludeLengthUnit { get; set; } = false;
                public bool IncludeVolumeUnit { get; set; } = false;
            }
        }
    }
    public LocationsLocationDepositorSubDetailLevel LocationDepositorDetailLevel { get; set; } = new LocationsLocationDepositorSubDetailLevel();
    public class LocationsLocationDepositorSubDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;
    }
    public LocationsLocationDimensionSubDetailLevel LocationDimensionDetailLevel { get; set; } = new LocationsLocationDimensionSubDetailLevel();
    public class LocationsLocationDimensionSubDetailLevel
    {
        public bool IncludeLengthUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
        public bool IncludeWeightUnit { get; set; } = false;
    }
    public LocationsLocationLockReasonSubDetailLevel LocationLockReasonDetailLevel { get; set; } = new LocationsLocationLockReasonSubDetailLevel();
    public class LocationsLocationLockReasonSubDetailLevel
    {
        public bool IncludeLockReason { get; set; } = false;
    }
    public LocationsLocationPickingTypeSubDetailLevel LocationPickingTypeDetailLevel { get; set; } = new LocationsLocationPickingTypeSubDetailLevel();
    public class LocationsLocationPickingTypeSubDetailLevel
    {
        public bool IncludePickingType { get; set; } = false;
    }
    public LocationsLocationProductSubDetailLevel LocationProductDetailLevel { get; set; } = new LocationsLocationProductSubDetailLevel();
    public class LocationsLocationProductSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
    }
    public LocationsLocationProductAbcCategorySubDetailLevel LocationProductAbcCategoryDetailLevel { get; set; } = new LocationsLocationProductAbcCategorySubDetailLevel();
    public class LocationsLocationProductAbcCategorySubDetailLevel
    {
        public bool IncludeAbcCategory { get; set; } = false;
    }
    public LocationsLocationProductAttributeSubDetailLevel LocationProductAttributeDetailLevel { get; set; } = new LocationsLocationProductAttributeSubDetailLevel();

    public class LocationsLocationProductAttributeSubDetailLevel
    {
        public bool IncludeProductAttribute { get; set; } = false;

        public LocProductAttributeSubDetailLevel ProductAttributeDetailLevel { get; set; } = new LocProductAttributeSubDetailLevel();

        public class LocProductAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public LocationsLocationProductCategorySubDetailLevel LocationProductCategoryDetailLevel { get; set; } = new LocationsLocationProductCategorySubDetailLevel();
    public class LocationsLocationProductCategorySubDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }
    public LocationsLocationProductConstraintSubDetailLevel LocationProductConstraintDetailLevel { get; set; } = new LocationsLocationProductConstraintSubDetailLevel();
    public class LocationsLocationProductConstraintSubDetailLevel
    {
        public bool IncludeItemUnit { get; set; } = false;
        public LocationsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new LocationsItemUnitSubDetailLevel();

        public class LocationsItemUnitSubDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeUnit { get; set; } = false;
        }
    }
    public LocationsLocationStockAttributeSubDetailLevel LocationStockAttributeDetailLevel { get; set; } = new LocationsLocationStockAttributeSubDetailLevel();
    public class LocationsLocationStockAttributeSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public LocationsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new LocationsStockAttributeSubDetailLevel();

        public class LocationsStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public LocationsLocationUnitConstraintSubDetailLevel LocationUnitConstraintDetailLevel { get; set; } = new LocationsLocationUnitConstraintSubDetailLevel();
    public class LocationsLocationUnitConstraintSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }

    public LocationsLocationZoneSubDetailLevel LocationZoneDetailLevel { get; set; } = new LocationsLocationZoneSubDetailLevel();
    public class LocationsLocationZoneSubDetailLevel
    {
        public bool IncludeZone { get; set; } = false;
    }

    public bool IncludeBufferLocation { get; set; } = false;
    public LocationsBufferLocationSubDetailLevel BufferLocationDetailLevel { get; set; } = new LocationsBufferLocationSubDetailLevel();
    public class LocationsBufferLocationSubDetailLevel
    {
        public bool IncludeBuffLocation { get; set; } = false;
    }
}
