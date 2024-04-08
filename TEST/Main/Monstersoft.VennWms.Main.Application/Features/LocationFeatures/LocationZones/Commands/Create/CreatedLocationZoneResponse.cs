namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Create;

public class CreatedLocationZoneResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ZoneId { get; set; }
    public DateTime CreatedDate { get; set; }

}

