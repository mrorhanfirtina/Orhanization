namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.ResponseDtos;

public class OrderShipmentsOrderShipItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public OrderShipmentsOrderItemResponseDto? OrderItem { get; set; }
    public ICollection<OrderShipmentsOrderShipItemTaskResponseDto>? OrderShipItemTasks { get; set; }
    public OrderShipmentsProgressStatusResponseDto? ProgressStatus { get; set; }
}