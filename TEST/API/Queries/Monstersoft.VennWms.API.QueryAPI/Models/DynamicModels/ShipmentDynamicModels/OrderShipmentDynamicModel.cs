using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class OrderShipmentDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderShipmentsDetailLevel? DetailLevel { get; set; }
}

