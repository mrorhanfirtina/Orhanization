namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

public class UpdateOrderShipItemStockSubDto
{
    public Guid StockId { get; set; }
    public Guid StockPackTypeId { get; set; }
    public decimal Quantity { get; set; }
    public UpdateOrderShipItemTaskSubDto OrderShipItemTask { get; set; }
}

