using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.UpdateDtos;

public class UpdateOrderShipItemTaskSubDto
{
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public UpdateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<UpdateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }

}

