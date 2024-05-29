namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.ResponseDtos;

public class ProductStockAttributeProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}
