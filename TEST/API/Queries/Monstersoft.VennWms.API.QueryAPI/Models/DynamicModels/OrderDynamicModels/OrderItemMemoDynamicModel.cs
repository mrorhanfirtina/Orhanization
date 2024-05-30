using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderItemMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderItemMemosDetailLevel? DetailLevel { get; set; }
}

