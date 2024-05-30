namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;

public class ReceiptsReceiptItmStockAttrValueResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public ReceiptsStockAttributeResponseDto? StockAttribute { get; set; }
}
