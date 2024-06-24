namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationZoneResponseDto
{
    public Guid Id { get; set; }
    public Guid ZoneId { get; set; }
    public virtual LocationZoneResponseDto? Zone { get; set; }
}
