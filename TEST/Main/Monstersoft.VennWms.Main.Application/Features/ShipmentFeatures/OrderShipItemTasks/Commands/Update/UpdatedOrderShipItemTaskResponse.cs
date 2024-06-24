using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Update;

public class UpdatedOrderShipItemTaskResponse
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<OrderShipItemTasksOrderShipItemStockResponseDto>? OrderShipItemStocks { get; set; }
    public OrderShipItemTasksWorkTaskResponseDto? WorkTask { get; set; }
    public OrderShipItemTasksOrderShipItemResponseDto? OrderShipItem { get; set; }
}
