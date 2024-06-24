namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;

public class UpdateOrderShipmentSubDto
{
    public string Code { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
}
