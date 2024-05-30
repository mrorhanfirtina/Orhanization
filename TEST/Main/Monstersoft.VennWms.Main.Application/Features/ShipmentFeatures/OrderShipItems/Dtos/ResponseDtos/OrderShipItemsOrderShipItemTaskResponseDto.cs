namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

public class OrderShipItemsOrderShipItemTaskResponseDto
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public ICollection<OrderShipItemsOrderShipItemStockResponseDto>? OrderShipItemStocks { get; set; }
}