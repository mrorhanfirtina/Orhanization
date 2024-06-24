namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductCategoryResponseDto
{
    public Guid Id { get; set; }
    public int CategoryId { get; set; }
    public ProductProductCategoryListResponseDto? Category { get; set; }
}
