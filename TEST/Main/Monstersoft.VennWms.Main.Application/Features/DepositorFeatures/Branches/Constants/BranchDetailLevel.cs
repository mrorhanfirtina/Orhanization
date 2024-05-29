namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;

public class BranchDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeAddress { get; set; } = false;
    public bool IncludeDistributor { get; set; } = false;

    public BranchDistributorDetailLevel DistributorDetailLevel { get; set; } = new BranchDistributorDetailLevel();
    public class BranchDistributorDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
