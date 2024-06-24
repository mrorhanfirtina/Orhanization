using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDimensions.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationDimensionDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationDimensionsDetailLevel? DetailLevel { get; set; }
}

