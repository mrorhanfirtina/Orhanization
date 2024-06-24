using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class ShipmentDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ShipmentsDetailLevel? DetailLevel { get; set; }
}

