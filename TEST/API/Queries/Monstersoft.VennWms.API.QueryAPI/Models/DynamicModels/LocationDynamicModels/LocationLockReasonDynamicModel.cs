using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationLockReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationLockReasonsDetailLevel? DetailLevel { get; set; }
}

