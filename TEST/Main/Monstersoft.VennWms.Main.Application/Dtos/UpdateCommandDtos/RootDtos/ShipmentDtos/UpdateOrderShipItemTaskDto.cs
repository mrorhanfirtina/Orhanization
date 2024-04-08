using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;

public class UpdateOrderShipItemTaskDto
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public UpdateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<UpdateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }
}

