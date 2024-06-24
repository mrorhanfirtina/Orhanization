using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderItemDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderItemsDetailLevel? DetailLevel { get; set; }
}

