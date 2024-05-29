namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;

public class UpdateOrderShipItemDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ShipmentId { get; set; }

}

