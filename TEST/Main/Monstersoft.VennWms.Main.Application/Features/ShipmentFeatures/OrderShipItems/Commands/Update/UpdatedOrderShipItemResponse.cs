using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;

public class UpdatedOrderShipItemResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderShipItemsOrderItemResponseDto? OrderItem { get; set; }
    public OrderShipItemsOrderShipmentResponseDto? OrderShipment { get; set; }
    public ICollection<OrderShipItemsOrderShipItemTaskResponseDto>? OrderShipItemTasks { get; set; }
    public OrderShipItemsProgressStatusResponseDto ProgressStatus { get; set; }
}
