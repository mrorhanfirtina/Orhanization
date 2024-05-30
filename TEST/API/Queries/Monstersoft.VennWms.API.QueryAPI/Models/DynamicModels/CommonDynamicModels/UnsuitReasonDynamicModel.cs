using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class UnsuitReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public UnsuitReasonsDetailLevel? DetailLevel { get; set; }
}

