using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class ShipmentAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ShipmentAttributesValueDetailLevel? DetailLevel { get; set; }
}

