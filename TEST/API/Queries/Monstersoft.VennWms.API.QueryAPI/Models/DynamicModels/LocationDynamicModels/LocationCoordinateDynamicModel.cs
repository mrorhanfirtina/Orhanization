using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCoordinates.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationCoordinateDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationCoordinatesDetailLevel? DetailLevel { get; set; }
}

