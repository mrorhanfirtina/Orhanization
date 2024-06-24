namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.ResponseDtos;

public class OrderItemMemoOrderItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public OrderItemMemoOrderResponseDto? Order { get; set; }
    public OrderItemMemoProductResponseDto? Product { get; set; }
}
