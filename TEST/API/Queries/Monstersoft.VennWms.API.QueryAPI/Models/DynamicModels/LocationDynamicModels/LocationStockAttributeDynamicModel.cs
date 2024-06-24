using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationStockAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationStockAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationStockAttributesDetailLevel? DetailLevel { get; set; }
}

