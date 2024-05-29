namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;

public class ReceiverDetailLevel
{
    public bool IncludeAddress { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeCustomer { get; set; } = false;

    public ReceiverCustomerDetailLevel CustomerDetailLevel { get; set; } = new ReceiverCustomerDetailLevel();
    public class ReceiverCustomerDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

}
