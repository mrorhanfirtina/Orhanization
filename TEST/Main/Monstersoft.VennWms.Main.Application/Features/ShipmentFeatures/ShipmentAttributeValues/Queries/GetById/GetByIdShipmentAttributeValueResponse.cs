namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Queries.GetById;

public class GetByIdShipmentAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
