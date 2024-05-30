using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class ReserveReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReserveReasonsDetailLevel? DetailLevel { get; set; }
}

