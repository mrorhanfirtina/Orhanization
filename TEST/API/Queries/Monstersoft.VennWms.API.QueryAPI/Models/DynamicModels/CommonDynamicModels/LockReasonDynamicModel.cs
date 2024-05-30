using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class LockReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LockReasonsDetailLevel? DetailLevel { get; set; }
}

