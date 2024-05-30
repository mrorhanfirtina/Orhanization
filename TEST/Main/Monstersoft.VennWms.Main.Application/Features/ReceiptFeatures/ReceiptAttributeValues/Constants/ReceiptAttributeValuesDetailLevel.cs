namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;

public class ReceiptAttributeValuesDetailLevel
{
    public bool IncludeReceipt { get; set; } = false;
    public bool IncludeReceiptAttribute { get; set; } = false;
    public ReceiptAttributeValuesReceiptAttributeSubDetailLevel ReceiptAttributeDetailLevel { get; set; } = new ReceiptAttributeValuesReceiptAttributeSubDetailLevel();
    public class ReceiptAttributeValuesReceiptAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }

}
