using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;

public class CreateOrderShipmentDto
{
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public DateTime LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public ICollection<CreateOrderShipItemSubDto> OrderShipItems { get; set; }
}

