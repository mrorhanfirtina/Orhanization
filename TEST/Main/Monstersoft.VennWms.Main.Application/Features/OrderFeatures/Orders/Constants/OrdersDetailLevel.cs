namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;

public class OrdersDetailLevel
{
    public bool IncludeCustomer { get; set; } = false;
    public OrdersCustomerSubDetailLevel CustomerDetailLevel { get; set; } = new OrdersCustomerSubDetailLevel();
    public class OrdersCustomerSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
        public bool IncludeAddress { get; set; } = false;
    }

    public bool IncludeOrderPriority { get; set; } = false;
    public OrdersOrderPrioritySubDetailLevel OrderPriorityDetailLevel { get; set; } = new OrdersOrderPrioritySubDetailLevel();
    public class OrdersOrderPrioritySubDetailLevel
    {
        public bool IncludePriorityList { get; set; } = false;
    }

    public bool IncludeOrderShipment { get; set; } = false;
    public OrdersOrderShipmentSubDetailLevel OrderShipmentDetailLevel { get; set; } = new OrdersOrderShipmentSubDetailLevel();
    public class OrdersOrderShipmentSubDetailLevel
    {
        public bool IncludeShipment { get; set; } = false;
        public bool IncludeProgressStatus { get; set; } = false;
    }

    public bool IncludeOrderType { get; set; } = false;
    public bool IncludeOrderAttributeValue { get; set; } = false;
    public OrdersOrderAttributeValueSubDetailLevel OrderAttributeValueDetailLevel { get; set; } = new OrdersOrderAttributeValueSubDetailLevel();
    public class OrdersOrderAttributeValueSubDetailLevel
    {
        public bool IncludeOrderAttribute { get; set; } = false;
        public OrdersOrderAttributeSubDetailLevel OrderAttributeDetailLevel { get; set; } = new OrdersOrderAttributeSubDetailLevel();
        public class OrdersOrderAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public bool IncludeOrderMemo { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public OrdersDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new OrdersDepositorSubDetailLevel();
    public class OrdersDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeDepositorCompany { get; set; } = false;
    public OrdersDepositorCompanySubDetailLevel DepositorCompanyDetailLevel { get; set; } = new OrdersDepositorCompanySubDetailLevel();
    public class OrdersDepositorCompanySubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeReceiver { get; set; } = false;
    public OrdersReceiverSubDetailLevel ReceiverDetailLevel { get; set; } = new OrdersReceiverSubDetailLevel();
    public class OrdersReceiverSubDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
    }

    public bool IncludeStatus { get; set; } = false;

    public bool IncludeOrderItem { get; set; } = false;
    public OrdersOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new OrdersOrderItemSubDetailLevel();
    public class OrdersOrderItemSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeOrderItemMemo { get; set; } = false;
        public bool IncludeOrderItemStockAttrValue { get; set; } = false;
        public OrdersStockAttrValueSubDetailLevel StockAttrValueDetailLevel { get; set; } = new OrdersStockAttrValueSubDetailLevel();
        public class OrdersStockAttrValueSubDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;
            public OrdersStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new OrdersStockAttributeSubDetailLevel();
            public class OrdersStockAttributeSubDetailLevel
            {
                public bool IncludeAttributeInputType { get; set; } = false;
            }
        }

        public bool IncludeOrderShipItem { get; set; } = false;
        public OrdersOrderShipItemSubDetailLevel OrderShipItemDetailLevel { get; set; } = new OrdersOrderShipItemSubDetailLevel();
        public class OrdersOrderShipItemSubDetailLevel
        {
            public bool IncludeProgressStatus { get; set; } = false;
        }

        public bool IncludeItemUnit { get; set; } = false;
        public OrdersItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new OrdersItemUnitSubDetailLevel();
        public class OrdersItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}