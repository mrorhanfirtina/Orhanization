namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Dtos.ResponseDtos;

public class ProductAttributeValueProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}
