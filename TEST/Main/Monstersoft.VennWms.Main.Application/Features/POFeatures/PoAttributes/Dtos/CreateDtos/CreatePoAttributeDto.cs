namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.CreateDtos;

public class CreatePoAttributeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

