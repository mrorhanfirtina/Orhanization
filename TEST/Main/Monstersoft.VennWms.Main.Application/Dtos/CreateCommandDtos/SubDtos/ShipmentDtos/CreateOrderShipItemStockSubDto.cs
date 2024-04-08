namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

public class CreateOrderShipItemStockSubDto
{
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public CreateOrderShipItemTaskSubDto OrderShipItemTask { get; set; }
}

