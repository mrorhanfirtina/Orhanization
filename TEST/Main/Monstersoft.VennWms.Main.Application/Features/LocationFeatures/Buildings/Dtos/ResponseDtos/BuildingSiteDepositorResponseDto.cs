namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.ResponseDtos;

public class BuildingSiteDepositorResponseDto
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public BuildingDepositorResponseDto? Depositor { get; set; }
}
