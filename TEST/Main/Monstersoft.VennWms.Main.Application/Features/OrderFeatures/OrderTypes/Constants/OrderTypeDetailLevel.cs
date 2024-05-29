namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;

public class OrderTypeDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeOrder { get; set; } = false;

    public OrderTypeOrderDetailLevel OrderDetailLevel { get; set; } = new OrderTypeOrderDetailLevel();

    public class OrderTypeOrderDetailLevel
    {
        public bool IncludeCustomer { get; set; } = false;
        public bool IncludeDepositor { get; set; } = false;
        public bool IncludeReceiver { get; set; } = false;
    }
}
