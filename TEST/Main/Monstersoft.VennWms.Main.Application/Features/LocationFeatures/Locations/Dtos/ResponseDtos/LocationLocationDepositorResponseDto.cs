namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationDepositorResponseDto
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
    public virtual LocationDepositorResponseDto? Depositor { get; set; }
}
