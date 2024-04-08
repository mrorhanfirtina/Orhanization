namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;

public class UpdatedSiteDepositorResponse
{
    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

