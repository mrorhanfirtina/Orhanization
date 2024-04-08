namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

public class CreateOrderShipItemSubDto
{
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ShipmentId { get; set; }
    public ICollection<CreateOrderShipItemTaskSubDto> OrderShipItemTasks { get; set; }

}

