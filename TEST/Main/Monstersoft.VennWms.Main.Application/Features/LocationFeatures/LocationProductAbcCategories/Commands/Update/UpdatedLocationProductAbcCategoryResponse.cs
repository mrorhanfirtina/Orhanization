using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Commands.Update;

public class UpdatedLocationProductAbcCategoryResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int AbcCategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public LocationProductAbcCategoryAbcCategoryResponseDto? AbcCategory { get; set; }
    public LocationProductAbcCategoryLocationResponseDto? Location { get; set; }
}

