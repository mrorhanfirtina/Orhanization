namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;

public class BuildingsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeSite { get; set; } = false;
    public bool IncludeBuildingDimension { get; set; } = false;
    public bool IncludeStorageSystem { get; set; } = false;
    public bool IncludeZone { get; set; } = false;
    public BuildingsBuildingDimensionSubDetailLevel BuildingDimensionDetailLevel { get; set; } = new BuildingsBuildingDimensionSubDetailLevel();
    public class BuildingsBuildingDimensionSubDetailLevel
    {
        public bool IncludeLenghtUnit { get; set; } = false;
        public bool IncludeVolumeUnit { get; set; } = false;
    }
    public BuildingsSiteSubDetailLevel SiteDetailLevel { get; set; } = new BuildingsSiteSubDetailLevel();
    public class BuildingsSiteSubDetailLevel
    {
        public bool IncludeSiteDepositor { get; set; } = false;
        public BuildingsDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new BuildingsDepositorSubDetailLevel();

        public class BuildingsDepositorSubDetailLevel
        {
            public bool IncludeDepositor { get; set; } = false;
        }
    }
}
