namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;

public class OrderItemMemoDetailLevel
{
    public bool IncludeOrderItem { get; set; } = false;
    public OrderItemMemoOrderItemDetailLevel OrderItemDetailLevel { get; set; } = new OrderItemMemoOrderItemDetailLevel();
    public class OrderItemMemoOrderItemDetailLevel
    {
        public bool IncludeOrder { get; set; } = false;
        public OrderItemMemoOrderDetailLevel OrderDetailLevel { get; set; } = new OrderItemMemoOrderDetailLevel();
        public class OrderItemMemoOrderDetailLevel
        {
            public bool IncludeCustomer { get; set; } = false;
            public bool IncludeDepositor { get; set; } = false;
            public bool IncludeReceiver { get; set; } = false;
        }
    }
}
