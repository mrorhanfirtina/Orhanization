using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;

public class UpdateOrderShipItemDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ShipmentId { get; set; }
    public ICollection<UpdateOrderShipItemTaskSubDto> OrderShipItemTasks { get; set; }

}

