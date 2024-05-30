namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.ResponseDtos;

public class OrderShipItemTasksOrderShipItemStockResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public OrderShipItemTasksStockResponseDto? Stock { get; set; }
    public OrderShipItemTasksStockPackTypeResponseDto? StockPackType { get; set; }
}