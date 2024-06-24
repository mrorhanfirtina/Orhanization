namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.UpdateDtos;

public class UpdateProductAttributeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

