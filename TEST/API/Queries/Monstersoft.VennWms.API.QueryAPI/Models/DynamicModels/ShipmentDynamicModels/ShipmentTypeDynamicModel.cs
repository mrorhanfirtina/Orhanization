using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class ShipmentTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ShipmentTypesDetailLevel? DetailLevel { get; set; }
}

