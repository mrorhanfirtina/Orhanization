namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;

public class StockAttributeValuesDetailLevel
{
    public bool IncludeStock { get; set; } = false;
    public bool IncludeStockAttribute { get; set; } = false;
    public StockAttributeValuesStockAttributeSubDetailLevel TargetDetailLevel { get; set; } = new StockAttributeValuesStockAttributeSubDetailLevel();
    public class StockAttributeValuesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
