namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;

public class OrderShipItemsDetailLevel
{
    public bool IncludeProgressStatus { get; set; } = false;
    public bool IncludeOrderItem { get; set; } = false;
    public OrderShipItemsOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new OrderShipItemsOrderItemSubDetailLevel();
    public class OrderShipItemsOrderItemSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeItemUnit { get; set; } = false;
        public OrderShipItemsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new OrderShipItemsItemUnitSubDetailLevel();
        public class OrderShipItemsItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
    public bool IncludeOrderShipment { get; set; } = false;
    public OrderShipItemsOrderShipmentSubDetailLevel OrderShipmentDetailLevel { get; set; } = new OrderShipItemsOrderShipmentSubDetailLevel();
    public class OrderShipItemsOrderShipmentSubDetailLevel
    {
        public bool IncludeShipment { get; set; } = false;
    }
    public bool IncludeOrderShipItemTask { get; set; } = false;
    public OrderShipItemsOrderShipItemTaskSubDetailLevel OrderShipItemTaskDetailLevel { get; set; } = new OrderShipItemsOrderShipItemTaskSubDetailLevel();
    public class OrderShipItemsOrderShipItemTaskSubDetailLevel
    {
        public bool IncludeOrderShipItemStock { get; set; } = false;
    }
}
