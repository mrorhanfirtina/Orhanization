using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class ShipmentAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ShipmentAttributesDetailLevel? DetailLevel { get; set; }
}

