namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Constants;

public class LocationCoordinateDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeBuilding { get; set; } = false;
    public LocationCoordinateBuildingDetailLevel BuildingDetailLevel { get; set; } = new LocationCoordinateBuildingDetailLevel();
    public class LocationCoordinateBuildingDetailLevel
    {
        public bool IncludeBuildingDimension { get; set; } = false;
        public LocationCoordinateBuildingDimensionDetailLevel BuildingDimensionDetailLevel { get; set; } = new LocationCoordinateBuildingDimensionDetailLevel();

        public class LocationCoordinateBuildingDimensionDetailLevel
        {
            public bool IncludeLenghtUnit { get; set; } = false;
            public bool IncludeVolumeUnit { get; set; } = false;
        }
    }
}
