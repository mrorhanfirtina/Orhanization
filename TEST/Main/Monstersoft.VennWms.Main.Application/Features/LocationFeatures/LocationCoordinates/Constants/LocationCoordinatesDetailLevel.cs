namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Constants;

public class LocationCoordinatesDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeBuilding { get; set; } = false;
    public LocationCoordinatesBuildingSubDetailLevel BuildingDetailLevel { get; set; } = new LocationCoordinatesBuildingSubDetailLevel();
    public class LocationCoordinatesBuildingSubDetailLevel
    {
        public bool IncludeBuildingDimension { get; set; } = false;
        public LocationCoordinatesBuildingDimensionSubDetailLevel BuildingDimensionDetailLevel { get; set; } = new LocationCoordinatesBuildingDimensionSubDetailLevel();

        public class LocationCoordinatesBuildingDimensionSubDetailLevel
        {
            public bool IncludeLenghtUnit { get; set; } = false;
            public bool IncludeVolumeUnit { get; set; } = false;
        }
    }
}
