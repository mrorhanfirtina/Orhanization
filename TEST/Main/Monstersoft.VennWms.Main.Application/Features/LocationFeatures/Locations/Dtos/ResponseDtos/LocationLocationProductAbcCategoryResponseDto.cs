namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationProductAbcCategoryResponseDto
{
    public Guid Id { get; set; }
    public int AbcCategoryId { get; set; }
    public virtual LocationAbcCategoryResponseDto? AbcCategory { get; set; }
}
