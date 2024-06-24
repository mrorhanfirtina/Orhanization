using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Create;

public class CreatedOrderShipItemStockResponse
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderShipItemStocksOrderShipItemResponseDto? OrderShipItem { get; set; }
    public OrderShipItemStocksOrderShipItemTaskResponseDto? OrderShipItemTask { get; set; }
    public OrderShipItemStocksStockResponseDto? Stock { get; set; }
    public OrderShipItemStocksStockPackTypeResponseDto? StockPackType { get; set; }
}

