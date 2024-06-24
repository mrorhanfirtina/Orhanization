namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;

public class ReceiptItemsReceiptItmStockAttrValueResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public ReceiptItemsStockAttributeResponseDto? StockAttribute { get; set; }
}