namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;

public class OrderItemsDetailLevel
{
    public bool IncludeOrder { get; set; } = false;
    public bool IncludeOrderItemMemo { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeOrderItemStockAttrValue { get; set; } = false;

    public OrderItemsOrderItemStockAttrValueSubDetailLevel OrderItemStockAttrValueDetailLevel { get; set; } = new OrderItemsOrderItemStockAttrValueSubDetailLevel();

    public class OrderItemsOrderItemStockAttrValueSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;
        public OrderItemsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new OrderItemsStockAttributeSubDetailLevel();
        public class OrderItemsStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public bool IncludeOrderShipItem { get; set; } = false;
    public OrderItemsOrderShipItemSubDetailLevel OrderShipItemDetailLevel { get; set; } = new OrderItemsOrderShipItemSubDetailLevel();

    public class OrderItemsOrderShipItemSubDetailLevel
    {
        public bool IncludeProgressStatus { get; set; } = false;
    }

    public bool IncludeItemUnit { get; set; } = false;

    public OrderItemsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new OrderItemsItemUnitSubDetailLevel();

    public class OrderItemsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }

}
