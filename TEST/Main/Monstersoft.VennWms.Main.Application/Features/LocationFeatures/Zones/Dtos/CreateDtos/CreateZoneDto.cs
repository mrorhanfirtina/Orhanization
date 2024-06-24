namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.CreateDtos;

public class CreateZoneDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
}

