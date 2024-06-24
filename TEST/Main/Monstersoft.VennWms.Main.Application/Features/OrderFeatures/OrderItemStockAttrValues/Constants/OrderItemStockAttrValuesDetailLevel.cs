namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;

public class OrderItemStockAttrValuesDetailLevel
{
    public bool IncludeOrderItem { get; set; } = false;

    public OrderItemStockAttrValuesOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new OrderItemStockAttrValuesOrderItemSubDetailLevel();
    public class OrderItemStockAttrValuesOrderItemSubDetailLevel
    {
        public bool IncludeOrder { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }

    public bool IncludeStockAttribute { get; set; } = false;

    public OrderItemStockAttrValuesStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new OrderItemStockAttrValuesStockAttributeSubDetailLevel();
    public class OrderItemStockAttrValuesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
