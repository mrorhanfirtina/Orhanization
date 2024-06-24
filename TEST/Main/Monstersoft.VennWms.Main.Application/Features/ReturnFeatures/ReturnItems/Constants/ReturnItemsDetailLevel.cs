namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;

public class ReturnItemsDetailLevel
{
    public bool IncludeReturn { get; set; } = false;
    public bool IncludeReturnItemMemo { get; set; } = false;
    public bool IncludeReturnItmStockAttrValue { get; set; } = false;
    public ReturnItemsReturnItmStockAttrValueSubDetailLevel ReturnItmStockAttrValueDetailLevel { get; set; } = new ReturnItemsReturnItmStockAttrValueSubDetailLevel();
    public class ReturnItemsReturnItmStockAttrValueSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public ReturnItemsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReturnItemsStockAttributeSubDetailLevel();

        public class ReturnItemsStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public ReturnItemsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ReturnItemsItemUnitSubDetailLevel();
    public class ReturnItemsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }
    public bool IncludeStatus { get; set; } = false;
}
