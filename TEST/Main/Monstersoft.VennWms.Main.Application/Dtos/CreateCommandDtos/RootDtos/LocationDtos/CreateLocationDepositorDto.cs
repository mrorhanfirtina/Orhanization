namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationDepositorDto
{
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
}
