using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationFeatures.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationFeatureDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationFeaturesDetailLevel? DetailLevel { get; set; }
}

