namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.UpdateDtos;

public class UpdateLocationPriorityDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public int InboundPriority { get; set; }
    public int OutboundPriority { get; set; }
}
