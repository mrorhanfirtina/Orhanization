using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Create;

public class CreatedProductAbcCategoryResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int AbcCategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ProductAbcCategoryAbcCategoryListResponseDto? AbcCategory { get; set; }
    public ProductAbcCategoryProductResponseDto? Product { get; set; }
}


