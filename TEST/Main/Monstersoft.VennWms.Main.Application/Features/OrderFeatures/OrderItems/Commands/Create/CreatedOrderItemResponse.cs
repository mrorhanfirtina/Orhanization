using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Create;

public class CreatedOrderItemResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderItemOrderResponseDto? Order { get; set; }
    public ICollection<OrderItemOrderItemMemoResponseDto>? OrderItemMemos { get; set; }
    public ICollection<OrderItemOrderItemStockAttrValueResponseDto>? OrderItemStockAttrValues { get; set; }
    public ICollection<OrderItemOrderShipItemResponseDto>? OrderShipItems { get; set; }
    public OrderItemProductResponseDto? Product { get; set; }
    public OrderItemItemUnitResponseDto? ItemUnit { get; set; }

}
