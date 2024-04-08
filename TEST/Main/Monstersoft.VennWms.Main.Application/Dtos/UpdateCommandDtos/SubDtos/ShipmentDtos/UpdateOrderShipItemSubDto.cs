namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

public class UpdateOrderShipItemSubDto
{
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ShipmentId { get; set; }
    public ICollection<UpdateOrderShipItemTaskSubDto> OrderShipItemTasks { get; set; }
}

