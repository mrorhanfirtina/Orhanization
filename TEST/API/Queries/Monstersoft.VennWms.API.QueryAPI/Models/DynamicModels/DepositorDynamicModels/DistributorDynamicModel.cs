using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class DistributorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public DistributorsDetailLevel? DetailLevel { get; set; }
}

