namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetListByDynamic;

public class GetListByDynamicSiteDepositorListItemDto
{
    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

