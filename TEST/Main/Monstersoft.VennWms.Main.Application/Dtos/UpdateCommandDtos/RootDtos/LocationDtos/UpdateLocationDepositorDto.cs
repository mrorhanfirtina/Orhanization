namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

public class UpdateLocationDepositorDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
}
