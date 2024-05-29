namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;

public class DepositorDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositorFeature { get; set; } = false;
    public bool IncludeCompany { get; set; } = false;

    public DepositorCompanyDetailLevel CompanyDetailLevel { get; set; } = new DepositorCompanyDetailLevel();
    public class DepositorCompanyDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
    }
}
