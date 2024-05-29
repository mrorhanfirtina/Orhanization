namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.CreateDtos;

public class CreateProductAttributeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

