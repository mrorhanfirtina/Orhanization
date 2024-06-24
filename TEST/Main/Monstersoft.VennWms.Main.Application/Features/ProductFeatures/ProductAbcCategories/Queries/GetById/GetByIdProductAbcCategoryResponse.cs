using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetById;

public class GetByIdProductAbcCategoryResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int AbcCategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ProductAbcCategoryAbcCategoryListResponseDto? AbcCategory { get; set; }
    public ProductAbcCategoryProductResponseDto? Product { get; set; }
}


