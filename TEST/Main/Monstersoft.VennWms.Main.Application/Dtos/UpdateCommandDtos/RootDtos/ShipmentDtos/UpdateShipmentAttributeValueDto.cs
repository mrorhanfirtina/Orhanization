namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ShipmentDtos;

public class UpdateShipmentAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }

}

