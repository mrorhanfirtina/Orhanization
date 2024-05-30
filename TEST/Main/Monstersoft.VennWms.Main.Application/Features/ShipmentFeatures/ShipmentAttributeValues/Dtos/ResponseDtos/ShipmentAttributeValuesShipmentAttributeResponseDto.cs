namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.ResponseDtos;

public class ShipmentAttributeValuesShipmentAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public ShipmentAttributeValuesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
