namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;

public class CreatedSiteDepositorResponse
{
    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
}

