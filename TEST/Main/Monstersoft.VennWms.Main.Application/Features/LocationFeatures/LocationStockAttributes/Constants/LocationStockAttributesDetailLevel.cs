namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants;

public class LocationStockAttributesDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeStockAttribute { get; set; } = false;
    public LocationStockAttributesStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new LocationStockAttributesStockAttributeSubDetailLevel();
    public class LocationStockAttributesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
