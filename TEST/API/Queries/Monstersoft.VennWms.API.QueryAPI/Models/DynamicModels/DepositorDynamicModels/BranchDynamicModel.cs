using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class BranchDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BranchesDetailLevel? DetailLevel { get; set; }
}

