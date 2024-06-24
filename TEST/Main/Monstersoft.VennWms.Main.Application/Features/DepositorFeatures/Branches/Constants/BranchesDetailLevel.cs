namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;

public class BranchesDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeAddress { get; set; } = false;
    public bool IncludeDistributor { get; set; } = false;

    public BranchesDistributorSubDetailLevel DistributorDetailLevel { get; set; } = new BranchesDistributorSubDetailLevel();
    public class BranchesDistributorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
