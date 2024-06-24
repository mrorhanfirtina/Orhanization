using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationsDetailLevel? DetailLevel { get; set; }
}

