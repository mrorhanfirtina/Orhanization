namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Dtos.UpdateDtos;

public class UpdateZoneDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
}

