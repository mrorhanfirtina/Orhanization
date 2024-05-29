namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures;

public class CreateReturnAttributeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

