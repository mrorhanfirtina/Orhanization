namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;

public class ReceiptItmStockAttrValuesDetailLevel
{
    public bool IncludeStockAttribute { get; set; } = false;
    public ReceiptItmStockAttrValuesStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReceiptItmStockAttrValuesStockAttributeSubDetailLevel();
    public class ReceiptItmStockAttrValuesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }

    public bool IncludeReceiptItem { get; set; } = false;
    public ReceiptItmStockAttrValuesReceiptItemSubDetailLevel ReceiptItemDetailLevel { get; set; } = new ReceiptItmStockAttrValuesReceiptItemSubDetailLevel();
    public class ReceiptItmStockAttrValuesReceiptItemSubDetailLevel
    {
        public bool IncludeReceipt { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
}
