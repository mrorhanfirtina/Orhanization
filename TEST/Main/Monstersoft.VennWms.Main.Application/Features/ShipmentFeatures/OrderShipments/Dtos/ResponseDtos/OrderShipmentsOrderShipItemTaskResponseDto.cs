namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.ResponseDtos;

public class OrderShipmentsOrderShipItemTaskResponseDto
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public ICollection<OrderShipmentsOrderShipItemStockResponseDto>? OrderShipItemStocks { get; set; }
}