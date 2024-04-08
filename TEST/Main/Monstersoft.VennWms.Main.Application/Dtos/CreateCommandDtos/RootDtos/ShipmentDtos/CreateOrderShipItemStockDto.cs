using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;

public class CreateOrderShipItemStockDto
{
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public CreateOrderShipItemTaskSubDto OrderShipItemTask { get; set; }
}

