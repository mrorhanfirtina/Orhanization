namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ShipmentDtos;

public class CreateShipmentAttributeValueDto
{
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }

}

