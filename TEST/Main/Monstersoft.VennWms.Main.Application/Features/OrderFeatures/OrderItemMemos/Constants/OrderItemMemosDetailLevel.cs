namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;

public class OrderItemMemosDetailLevel
{
    public bool IncludeOrderItem { get; set; } = false;
    public OrderItemMemosOrderItemSubDetailLevel OrderItemDetailLevel { get; set; } = new OrderItemMemosOrderItemSubDetailLevel();
    public class OrderItemMemosOrderItemSubDetailLevel
    {
        public bool IncludeOrder { get; set; } = false;
        public OrderItemMemosOrderSubDetailLevel OrderDetailLevel { get; set; } = new OrderItemMemosOrderSubDetailLevel();
        public class OrderItemMemosOrderSubDetailLevel
        {
            public bool IncludeCustomer { get; set; } = false;
            public bool IncludeDepositor { get; set; } = false;
            public bool IncludeReceiver { get; set; } = false;
        }
    }
}
