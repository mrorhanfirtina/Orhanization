namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.ResponseDtos;

public class OrderItemStockAttrValueOrderItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public OrderItemStockAttrValueOrderResponseDto? Order { get; set; }
    public OrderItemStockAttrValueProductResponseDto? Product { get; set; }
}
