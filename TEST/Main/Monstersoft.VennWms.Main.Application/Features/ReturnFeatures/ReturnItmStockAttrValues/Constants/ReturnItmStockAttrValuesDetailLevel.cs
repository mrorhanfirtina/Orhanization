namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;

public class ReturnItmStockAttrValuesDetailLevel
{
    public bool IncludeReturnItem { get; set; } = false;
    public ReturnItmStockAttrValuesReturnItemSubDetailLevel ReturnItemDetailLevel { get; set; } = new ReturnItmStockAttrValuesReturnItemSubDetailLevel();
    public class ReturnItmStockAttrValuesReturnItemSubDetailLevel
    {
        public bool IncludeReturn { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }

    public bool IncludeStockAttribute { get; set; } = false;
    public ReturnItmStockAttrValuesStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReturnItmStockAttrValuesStockAttributeSubDetailLevel();
    public class ReturnItmStockAttrValuesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
