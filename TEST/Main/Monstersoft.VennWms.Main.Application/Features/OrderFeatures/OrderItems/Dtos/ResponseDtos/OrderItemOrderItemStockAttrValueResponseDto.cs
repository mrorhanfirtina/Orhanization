namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

public class OrderItemOrderItemStockAttrValueResponseDto
{
    public Guid Id { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public OrderItemStockAttributeResponseDto? StockAttribute { get; set; }
}