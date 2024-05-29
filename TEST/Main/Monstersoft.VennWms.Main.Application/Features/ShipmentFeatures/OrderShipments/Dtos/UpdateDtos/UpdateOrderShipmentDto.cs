using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Dtos.UpdateDtos;

public class UpdateOrderShipmentDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public ICollection<UpdateOrderShipItemSubDto> OrderShipItems { get; set; }
}

