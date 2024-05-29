namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;

public class LocationProductAttributeDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeProductAttribute { get; set; } = false;
    public LocationProductAttributeProductAttributeDetailLevel ProductAttributeDetailLevel { get; set; } = new LocationProductAttributeProductAttributeDetailLevel();
    public class LocationProductAttributeProductAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
