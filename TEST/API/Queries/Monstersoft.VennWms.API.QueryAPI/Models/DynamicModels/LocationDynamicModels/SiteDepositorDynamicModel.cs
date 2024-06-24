using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class SiteDepositorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SiteDepositorsDetailLevel? DetailLevel { get; set; }
}

