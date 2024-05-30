namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;

public class LocationProductAttributesDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeProductAttribute { get; set; } = false;
    public LocationProductAttributesProductAttributeSubDetailLevel ProductAttributeDetailLevel { get; set; } = new LocationProductAttributesProductAttributeSubDetailLevel();
    public class LocationProductAttributesProductAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
