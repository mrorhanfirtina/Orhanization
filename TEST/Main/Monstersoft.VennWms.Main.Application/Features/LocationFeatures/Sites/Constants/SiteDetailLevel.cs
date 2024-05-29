namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;

public class SiteDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeSiteDepositor { get; set; } = false;
    public bool IncludeBuilding { get; set; } = false;
    public SiteSiteDepositorDetailLevel SiteDepositorDetailLevel { get; set; } = new SiteSiteDepositorDetailLevel();
    public class SiteSiteDepositorDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;
    }
}
