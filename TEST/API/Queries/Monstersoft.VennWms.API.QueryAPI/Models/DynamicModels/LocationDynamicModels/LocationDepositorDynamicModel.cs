using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationDepositorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationDepositorsDetailLevel? DetailLevel { get; set; }
}

