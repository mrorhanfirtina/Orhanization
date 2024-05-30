namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;

public class ShipmentsShipmentAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public ShipmentsAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}