using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.CreateDtos;

public class CreateOrderShipItemTaskSubDto
{
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public CreateOrderShipItemSubDto OrderShipItem { get; set; }
    public ICollection<CreateOrderShipItemStockSubDto> OrderShipItemStocks { get; set; }

}

