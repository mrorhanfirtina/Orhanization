using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class ActionParameterDepositorDynamicModel
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ActionParameterDepositorDetailLevel? DetailLevel { get; set; }
}
