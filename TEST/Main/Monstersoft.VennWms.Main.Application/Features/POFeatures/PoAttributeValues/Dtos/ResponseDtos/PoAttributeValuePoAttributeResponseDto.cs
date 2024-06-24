namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.ResponseDtos;

public class PoAttributeValuePoAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public PoAttributeValueAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}
