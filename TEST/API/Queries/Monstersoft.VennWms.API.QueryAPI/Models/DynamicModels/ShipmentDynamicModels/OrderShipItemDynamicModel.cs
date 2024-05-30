using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class OrderShipItemDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderShipItemsDetailLevel? DetailLevel { get; set; }
}

