namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;

public class ReceiptItemsDetailLevel
{
    public bool IncludeReceiptItemMemo { get; set; } = false;
    public bool IncludeReceiptItmStockAttrValue { get; set; } = false;
    public ReceiptItemsReceiptItmStockAttrValueSubDetailLevel ReceiptItmStockAttrValueDetailLevel { get; set; } = new ReceiptItemsReceiptItmStockAttrValueSubDetailLevel();
    public class ReceiptItemsReceiptItmStockAttrValueSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public ReceiptItemsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReceiptItemsStockAttributeSubDetailLevel();
        public class ReceiptItemsStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public ReceiptItemsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ReceiptItemsItemUnitSubDetailLevel();
    public class ReceiptItemsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }
    public bool IncludeStatus { get; set; } = false;
    public bool IncludeReceipt { get; set; } = false;
}
