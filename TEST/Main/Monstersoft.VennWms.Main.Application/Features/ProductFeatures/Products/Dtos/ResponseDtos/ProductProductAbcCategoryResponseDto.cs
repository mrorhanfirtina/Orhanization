namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductAbcCategoryResponseDto
{
    public Guid Id { get; set; }
    public int AbcCategoryId { get; set; }
    public ProductAbcCategoryListResponseDto? AbcCategory { get; set; }
}
