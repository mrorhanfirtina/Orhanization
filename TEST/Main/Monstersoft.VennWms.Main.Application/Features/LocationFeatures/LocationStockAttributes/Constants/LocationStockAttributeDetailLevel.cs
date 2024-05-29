namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants;

public class LocationStockAttributeDetailLevel
{
    public bool IncludeLocation { get; set; } = false;
    public bool IncludeStockAttribute { get; set; } = false;
    public LocationStockAttributeStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new LocationStockAttributeStockAttributeDetailLevel();
    public class LocationStockAttributeStockAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
