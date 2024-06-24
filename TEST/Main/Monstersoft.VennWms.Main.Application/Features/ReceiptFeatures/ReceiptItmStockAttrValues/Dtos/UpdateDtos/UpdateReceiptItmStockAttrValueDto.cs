namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures;

public class UpdateReceiptItmStockAttrValueDto
{
    public Guid Id { get; set; }
    public Guid ReceiptItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

