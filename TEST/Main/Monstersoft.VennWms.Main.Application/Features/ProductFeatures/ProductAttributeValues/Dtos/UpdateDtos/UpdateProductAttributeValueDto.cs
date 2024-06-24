namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures;

public class UpdateProductAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
}

