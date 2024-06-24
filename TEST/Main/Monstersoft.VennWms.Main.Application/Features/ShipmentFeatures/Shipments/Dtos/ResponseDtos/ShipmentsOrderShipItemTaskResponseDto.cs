namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsOrderShipItemTaskResponseDto
{
    public Guid Id { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public ICollection<ShipmentsOrderShipItemStockResponseDto>? OrderShipItemStocks { get; set; }
}