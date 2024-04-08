namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

public class UpdateOrderShipItemTaskSubDto
{
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public UpdateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<UpdateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }

}

