namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;

public class UpdateShipmentMemoDto
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

