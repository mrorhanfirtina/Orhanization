namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsOrderShipItemStockResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public ShipmentsStockResponseDto? Stock { get; set; }
    public ShipmentsStockPackTypeResponseDto? StockPackType { get; set; }
}