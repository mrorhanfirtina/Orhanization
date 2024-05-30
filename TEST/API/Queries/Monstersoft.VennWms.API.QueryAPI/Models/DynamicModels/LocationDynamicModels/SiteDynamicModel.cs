using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class SiteDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SitesDetailLevel? DetailLevel { get; set; }
}

