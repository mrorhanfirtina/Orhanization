namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;

public class OrderItemStockAttrValueDetailLevel
{
    public bool IncludeOrderItem { get; set; } = false;

    public OrderItemStockAttrValueOrderItemDetailLevel OrderItemDetailLevel { get; set; } = new OrderItemStockAttrValueOrderItemDetailLevel();
    public class OrderItemStockAttrValueOrderItemDetailLevel
    {
        public bool IncludeOrder { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }

    public bool IncludeStockAttribute { get; set; } = false;

    public OrderItemStockAttrValueStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new OrderItemStockAttrValueStockAttributeDetailLevel();
    public class OrderItemStockAttrValueStockAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
