namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetById;

public class GetByIdSiteDepositorResponse
{
    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

