namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;

public class OrderItemDetailLevel
{
    public bool IncludeOrder { get; set; } = false;
    public bool IncludeOrderItemMemo { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeOrderItemStockAttrValue { get; set; } = false;

    public OrderItemOrderItemStockAttrValueDetailLevel OrderItemStockAttrValueDetailLevel { get; set; } = new OrderItemOrderItemStockAttrValueDetailLevel();

    public class OrderItemOrderItemStockAttrValueDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;
        public OrderItemOrderItemStockAttrValueStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new OrderItemOrderItemStockAttrValueStockAttributeDetailLevel();
        public class OrderItemOrderItemStockAttrValueStockAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public bool IncludeOrderShipItem { get; set; } = false;
    public OrderItemOrderShipItemDetailLevel OrderShipItemDetailLevel { get; set; } = new OrderItemOrderShipItemDetailLevel();

    public class OrderItemOrderShipItemDetailLevel
    {
        public bool IncludeProgressStatus { get; set; } = false;
    }

    public bool IncludeItemUnit { get; set; } = false;

    public OrderItemItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new OrderItemItemUnitDetailLevel();

    public class OrderItemItemUnitDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }

}
