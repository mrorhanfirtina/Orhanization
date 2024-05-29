namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;

public class BuildingDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeSite { get; set; } = false;
    public bool IncludeBuildingDimension { get; set; } = false;
    public bool IncludeStorageSystem { get; set; } = false;
    public bool IncludeZone { get; set; } = false;
    public BuildingBuildingDimensionDetailLevel BuildingDimensionDetailLevel { get; set; } = new BuildingBuildingDimensionDetailLevel();
    public class BuildingBuildingDimensionDetailLevel
    {
        public bool IncludeLenghtUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
    }
    public BuildingSiteDetailLevel SiteDetailLevel { get; set; } = new BuildingSiteDetailLevel();
    public class BuildingSiteDetailLevel
    {
        public bool IncludeSiteDepositor { get; set; } = false;
        public SiteDepositorDetailLevel DepositorDetailLevel { get; set; } = new SiteDepositorDetailLevel();

        public class SiteDepositorDetailLevel
        {
            public bool IncludeDepositor { get; set; } = false;
        }
    }
}
