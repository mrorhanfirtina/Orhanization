using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class DepositorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public DepositorsDetailLevel? DetailLevel { get; set; }
}

