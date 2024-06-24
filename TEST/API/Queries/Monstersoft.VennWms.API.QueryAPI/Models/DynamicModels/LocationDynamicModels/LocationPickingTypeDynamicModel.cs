using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPickingTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationPickingTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationPickingTypesDetailLevel? DetailLevel { get; set; }
}

