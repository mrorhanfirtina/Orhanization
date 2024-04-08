using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;

public class CreateOrderShipItemTaskDto
{
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public CreateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<CreateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }
}

