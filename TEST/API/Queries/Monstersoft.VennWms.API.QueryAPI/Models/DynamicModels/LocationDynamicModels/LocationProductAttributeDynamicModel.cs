using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationProductAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationProductAttributesDetailLevel? DetailLevel { get; set; }
}

