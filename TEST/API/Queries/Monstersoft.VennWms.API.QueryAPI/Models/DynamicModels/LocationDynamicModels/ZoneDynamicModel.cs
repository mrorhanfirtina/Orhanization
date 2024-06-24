using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class ZoneDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ZonesDetailLevel? DetailLevel { get; set; }
}

