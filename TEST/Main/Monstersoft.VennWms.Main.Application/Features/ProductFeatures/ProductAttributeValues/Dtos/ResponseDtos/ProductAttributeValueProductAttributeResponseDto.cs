namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.ResponseDtos;

public class ProductAttributeValueProductAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public ProductAttributeValueAttributeInputTypeResponseDto? ProductAttribute { get; set; }
}
