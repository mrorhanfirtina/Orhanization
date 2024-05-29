using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Queries.GetListByDynamic;

public class GetListByDynamicLocationProductCategoryListItemDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationProductCategoryCategoryResponseDto? Category { get; set; }
    public LocationProductCategoryLocationResponseDto? Location { get; set; }
}

