namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.UpdateDtos;

public class UpdateLocationDepositorDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
}
