namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;

public class OrderTypesDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeOrder { get; set; } = false;

    public OrderTypesOrderSubDetailLevel OrderDetailLevel { get; set; } = new OrderTypesOrderSubDetailLevel();

    public class OrderTypesOrderSubDetailLevel
    {
        public bool IncludeCustomer { get; set; } = false;
        public bool IncludeDepositor { get; set; } = false;
        public bool IncludeReceiver { get; set; } = false;
    }
}
