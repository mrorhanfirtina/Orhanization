namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Dtos.ResponseDtos;

public class LocationProductAttributeProductAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public LocationProductAttributeAttributeInputTypeResponseDto AttributeInputType { get; set; }
}
