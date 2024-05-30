namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

public class OrderShipItemsOrderItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public OrderShipItemsProductResponseDto? Product { get; set; }
    public OrderShipItemsItemUnitResponseDto? ItemUnit { get; set; }
}