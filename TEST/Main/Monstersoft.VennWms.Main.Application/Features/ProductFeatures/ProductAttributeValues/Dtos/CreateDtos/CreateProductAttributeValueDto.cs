namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.CreateDtos;

public class CreateProductAttributeValueDto
{
    public Guid ProductId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
}

