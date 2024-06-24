namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationProductResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
    public virtual LocationProductResponseDto? Product { get; set; }
}
