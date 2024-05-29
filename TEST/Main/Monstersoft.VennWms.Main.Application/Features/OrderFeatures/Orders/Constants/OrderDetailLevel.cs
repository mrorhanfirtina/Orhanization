namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;

public class OrderDetailLevel
{
    public bool IncludeCustomer { get; set; } = false;
    public OrderCustomerDetailLevel CustomerDetailLevel { get; set; } = new OrderCustomerDetailLevel();
    public class OrderCustomerDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
        public bool IncludeAddress { get; set; } = false;
    }

    public bool IncludeOrderPriority { get; set; } = false;
    public OrderOrderPriorityDetailLevel OrderPriorityDetailLevel { get; set; } = new OrderOrderPriorityDetailLevel();
    public class OrderOrderPriorityDetailLevel
    {
        public bool IncludePriorityList { get; set; } = false;
    }

    public bool IncludeOrderShipment { get; set; } = false;
    public OrderOrderShipmentDetailLevel OrderShipmentDetailLevel { get; set; } = new OrderOrderShipmentDetailLevel();
    public class OrderOrderShipmentDetailLevel
    {
        public bool IncludeShipment { get; set; } = false;
        public bool IncludeProgressStatus { get; set; } = false;
    }

    public bool IncludeOrderType { get; set; } = false;
    public bool IncludeOrderAttributeValue { get; set; } = false;
    public OrderOrderAttributeValueDetailLevel OrderAttributeValueDetailLevel { get; set; } = new OrderOrderAttributeValueDetailLevel();
    public class OrderOrderAttributeValueDetailLevel
    {
        public bool IncludeOrderAttribute { get; set; } = false;
        public OrderAttributeValueOrderAttributeDetailLevel OrderAttributeDetailLevel { get; set; } = new OrderAttributeValueOrderAttributeDetailLevel();
        public class OrderAttributeValueOrderAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public bool IncludeOrderMemo { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public OrderDepositorDetailLevel DepositorDetailLevel { get; set; } = new OrderDepositorDetailLevel();
    public class OrderDepositorDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeDepositorCompany { get; set; } = false;
    public OrderDepositorCompanyDetailLevel DepositorCompanyDetailLevel { get; set; } = new OrderDepositorCompanyDetailLevel();
    public class OrderDepositorCompanyDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeReceiver { get; set; } = false;
    public OrderReceiverDetailLevel ReceiverDetailLevel { get; set; } = new OrderReceiverDetailLevel();
    public class OrderReceiverDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
    }

    public bool IncludeStatus { get; set; } = false;

    public bool IncludeOrderItem { get; set; } = false;
    public OrderOrderItemDetailLevel OrderItemDetailLevel { get; set; } = new OrderOrderItemDetailLevel();
    public class OrderOrderItemDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeOrderItemMemo { get; set; } = false;
        public bool IncludeOrderItemStockAttrValue { get; set; } = false;
        public OrderStockAttrValueDetailLevel StockAttrValueDetailLevel { get; set; } = new OrderStockAttrValueDetailLevel();
        public class OrderStockAttrValueDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;
            public OrderStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new OrderStockAttributeDetailLevel();
            public class OrderStockAttributeDetailLevel
            {
                public bool IncludeAttributeInputType { get; set; } = false;
            }
        }

        public bool IncludeOrderShipItem { get; set; } = false;
        public OrderOrderShipItemDetailLevel OrderShipItemDetailLevel { get; set; } = new OrderOrderShipItemDetailLevel();
        public class OrderOrderShipItemDetailLevel
        {
            public bool IncludeProgressStatus { get; set; } = false;
        }

        public bool IncludeItemUnit { get; set; } = false;
        public OrderItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new OrderItemUnitDetailLevel();
        public class OrderItemUnitDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}