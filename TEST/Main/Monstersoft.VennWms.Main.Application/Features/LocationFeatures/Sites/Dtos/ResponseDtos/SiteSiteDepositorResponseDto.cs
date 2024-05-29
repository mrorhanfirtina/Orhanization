namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.ResponseDtos;

public class SiteSiteDepositorResponseDto
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public SiteDepositorResponseDto? Depositor { get; set; }
}
