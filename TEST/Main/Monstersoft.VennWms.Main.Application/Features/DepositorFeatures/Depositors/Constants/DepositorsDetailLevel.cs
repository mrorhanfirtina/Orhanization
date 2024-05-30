namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;

public class DepositorsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositorFeature { get; set; } = false;
    public bool IncludeCompany { get; set; } = false;

    public DepositorsCompanySubDetailLevel CompanyDetailLevel { get; set; } = new DepositorsCompanySubDetailLevel();
    public class DepositorsCompanySubDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
    }
}
