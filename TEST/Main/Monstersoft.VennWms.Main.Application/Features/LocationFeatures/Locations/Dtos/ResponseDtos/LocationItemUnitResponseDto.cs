namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public LocationProductResponseDto? Product { get; set; }
    public LocationUnitResponseDto? Unit { get; set; }
}
