using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class OrderShipItemStockDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderShipItemStocksDetailLevel? DetailLevel { get; set; }
}

