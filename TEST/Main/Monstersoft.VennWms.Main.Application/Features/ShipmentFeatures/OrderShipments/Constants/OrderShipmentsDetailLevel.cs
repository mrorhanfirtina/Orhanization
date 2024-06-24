namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;

public class OrderShipmentsDetailLevel
{
    public bool IncludeShipment { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeProgressStatus { get; set; } = false;
    public bool IncludeOrder { get; set; } = false;
    public bool IncludeOrderShipItem { get; set; } = false;
    public OrderShipmentsOrderShipItemSubDetailLevel OrderShipItemDetailLevel { get; set; } = new OrderShipmentsOrderShipItemSubDetailLevel();
    public class OrderShipmentsOrderShipItemSubDetailLevel
    {
        public bool IncludeOrderItem { get; set; } = false;
        public OrderShipmentsOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new OrderShipmentsOrderItemSubDetailLevel();
        public class OrderShipmentsOrderItemSubDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeItemUnit { get; set; } = false;
            public OrderShipmentsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new OrderShipmentsItemUnitSubDetailLevel();
            public class OrderShipmentsItemUnitSubDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }

        public bool IncludeOrderShipItemTasks { get; set; } = false;
        public OrderShipmentsOrderShipItemTaskSubDetailLevel OrderShipItemTaskDetailLevel { get; set; } = new OrderShipmentsOrderShipItemTaskSubDetailLevel();
        public class OrderShipmentsOrderShipItemTaskSubDetailLevel
        {
            public bool IncludeOrderShipItemStock { get; set; } = false;
        }
    }
}
