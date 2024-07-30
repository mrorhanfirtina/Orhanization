namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.ResponseDtos;

public class BuildingsSiteResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public BuildingSiteDepositorResponseDto SiteDepositor { get; set; }
}
