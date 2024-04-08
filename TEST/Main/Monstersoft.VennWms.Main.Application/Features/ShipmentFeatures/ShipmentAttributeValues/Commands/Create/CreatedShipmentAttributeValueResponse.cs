namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Create;

public class CreatedShipmentAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }

}
