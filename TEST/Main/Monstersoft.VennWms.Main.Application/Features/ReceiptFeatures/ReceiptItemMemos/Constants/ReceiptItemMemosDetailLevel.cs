namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants;

public class ReceiptItemMemosDetailLevel
{
    public bool IncludeReceiptItem { get; set; } = false;
    public ReceiptItemMemosReceiptItemSubDetailLevel ReceiptItemDetailLevel { get; set; } = new ReceiptItemMemosReceiptItemSubDetailLevel();
    public class ReceiptItemMemosReceiptItemSubDetailLevel
    {
        public bool IncludeReceipt { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
}
