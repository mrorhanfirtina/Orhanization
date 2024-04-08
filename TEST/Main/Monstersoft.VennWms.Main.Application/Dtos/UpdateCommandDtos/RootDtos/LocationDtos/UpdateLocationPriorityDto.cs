namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationPriorityDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int InboundPriority { get; set; }
    public int OutboundPriority { get; set; }
}
