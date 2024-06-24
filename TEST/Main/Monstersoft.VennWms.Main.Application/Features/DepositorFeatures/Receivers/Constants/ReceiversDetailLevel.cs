namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;

public class ReceiversDetailLevel
{
    public bool IncludeAddress { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeCustomer { get; set; } = false;

    public ReceiversCustomerSubDetailLevel CustomerDetailLevel { get; set; } = new ReceiversCustomerSubDetailLevel();
    public class ReceiversCustomerSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

}
