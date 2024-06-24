using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationZoneDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationZonesDetailLevel? DetailLevel { get; set; }
}

