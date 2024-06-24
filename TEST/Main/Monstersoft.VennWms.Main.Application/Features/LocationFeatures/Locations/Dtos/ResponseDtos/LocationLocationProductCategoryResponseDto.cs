namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationProductCategoryResponseDto
{
    public Guid Id { get; set; }
    public int CategoryId { get; set; }
    public virtual LocationCategoryResponseDto? Category { get; set; }
}
