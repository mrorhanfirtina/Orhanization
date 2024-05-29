namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;

public class LocationProductConstraintDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public LocationProductConstraintItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new LocationProductConstraintItemUnitDetailLevel();
    public class LocationProductConstraintItemUnitDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeUnit { get; set; } = false;
    }
}
