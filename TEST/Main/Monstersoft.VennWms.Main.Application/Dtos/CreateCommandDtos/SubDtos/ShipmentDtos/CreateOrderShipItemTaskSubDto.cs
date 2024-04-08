namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

public class CreateOrderShipItemTaskSubDto
{
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public CreateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<CreateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }

}

