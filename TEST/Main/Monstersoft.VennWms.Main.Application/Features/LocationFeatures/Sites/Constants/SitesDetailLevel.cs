namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;

public class SitesDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeSiteDepositor { get; set; } = false;
    public bool IncludeBuilding { get; set; } = false;
    public SitesSiteDepositorSubDetailLevel SiteDepositorDetailLevel { get; set; } = new SitesSiteDepositorSubDetailLevel();
    public class SitesSiteDepositorSubDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;
    }
}
