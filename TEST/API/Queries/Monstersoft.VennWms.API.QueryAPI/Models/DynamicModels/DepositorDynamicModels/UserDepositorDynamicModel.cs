using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class UserDepositorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public UserDepositorsDetailLevel? DetailLevel { get; set; }
}

