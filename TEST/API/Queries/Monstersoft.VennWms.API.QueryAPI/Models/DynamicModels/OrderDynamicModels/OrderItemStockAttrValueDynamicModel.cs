using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderItemStockAttrValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderItemStockAttrValuesDetailLevel? DetailLevel { get; set; }
}

