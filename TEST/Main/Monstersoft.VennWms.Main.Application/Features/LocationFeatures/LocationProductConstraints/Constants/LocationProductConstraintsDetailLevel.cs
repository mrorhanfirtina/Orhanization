namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;

public class LocationProductConstraintsDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public LocationProductsConstraintItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new LocationProductsConstraintItemUnitSubDetailLevel();
    public class LocationProductsConstraintItemUnitSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeUnit { get; set; } = false;
    }
}
