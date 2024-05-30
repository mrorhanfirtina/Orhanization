using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Commands.Update;

public class UpdatedShipmentAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid ShipmentAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ShipmentAttributeValuesShipmentAttributeResponseDto? ShipmentAttribute { get; set; }
    public ShipmentAttributeValuesShipmentResponseDto? Shipment { get; set; }
}
