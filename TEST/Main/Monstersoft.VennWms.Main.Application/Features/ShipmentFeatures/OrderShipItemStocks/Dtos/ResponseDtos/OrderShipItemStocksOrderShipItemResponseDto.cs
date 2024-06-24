namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.ResponseDtos;

public class OrderShipItemStocksOrderShipItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
}