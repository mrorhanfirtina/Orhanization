namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.ResponseDtos;

public class ProductCategoryProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}
