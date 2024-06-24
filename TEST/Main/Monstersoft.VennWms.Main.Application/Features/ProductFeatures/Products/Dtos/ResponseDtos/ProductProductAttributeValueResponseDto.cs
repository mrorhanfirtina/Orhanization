namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public ProductProductAttributeResponseDto? ProductAttribute { get; set; }
}
