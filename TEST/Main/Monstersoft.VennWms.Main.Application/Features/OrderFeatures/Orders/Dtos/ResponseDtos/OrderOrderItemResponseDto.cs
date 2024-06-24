using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public OrderProductResponseDto? Product { get; set; }
    public OrderItemUnitResponseDto? ItemUnit { get; set; }
    public ICollection<OrderOrderItemMemoResponseDto>? OrderItemMemos { get; set; }
    public ICollection<OrderOrderItemStockAttrValueResponseDto>? OrderItemStockAttrValues { get; set; }
    public ICollection<OrderOrderShipItemResponseDto>? OrderShipItems { get; set; }
}
