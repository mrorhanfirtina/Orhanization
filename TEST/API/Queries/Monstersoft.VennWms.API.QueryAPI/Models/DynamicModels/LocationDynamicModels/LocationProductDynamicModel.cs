using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationProductDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationProductsDetailLevel? DetailLevel { get; set; }
}

