namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationPriorityDto
{
    public Guid LocationId { get; set; }
    public int InboundPriority { get; set; }
    public int OutboundPriority { get; set; }
}
