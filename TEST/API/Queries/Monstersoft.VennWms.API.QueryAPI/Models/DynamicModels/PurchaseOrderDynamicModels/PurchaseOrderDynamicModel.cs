using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;

public class PurchaseOrderDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PurchaseOrdersDetailLevel? DetailLevel { get; set; }
}

