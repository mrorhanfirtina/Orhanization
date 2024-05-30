namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsOrderShipItemResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public int ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public ShipmentsOrderItemResponseDto? OrderItem { get; set; }
    public ICollection<ShipmentsOrderShipItemTaskResponseDto>? OrderShipItemTasks { get; set; }
    public ShipmentsProgressStatusResponseDto? ProgressStatus { get; set; }
}