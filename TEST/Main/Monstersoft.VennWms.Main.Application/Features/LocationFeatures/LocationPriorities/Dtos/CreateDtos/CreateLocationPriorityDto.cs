namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.CreateDtos;

public class CreateLocationPriorityDto
{
    public Guid LocationId { get; set; }
    public int InboundPriority { get; set; }
    public int OutboundPriority { get; set; }
}
