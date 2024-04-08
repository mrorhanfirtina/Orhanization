using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;

public class UpdateOrderShipItemStockDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public UpdateOrderShipItemTaskSubDto OrderShipItemTask { get; set; }
}

