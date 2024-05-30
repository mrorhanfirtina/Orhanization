namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

public class OrderShipItemsOrderShipItemStockResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
}