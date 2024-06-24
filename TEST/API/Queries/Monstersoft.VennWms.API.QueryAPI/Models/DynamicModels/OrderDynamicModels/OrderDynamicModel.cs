using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrdersDetailLevel? DetailLevel { get; set; }
}

