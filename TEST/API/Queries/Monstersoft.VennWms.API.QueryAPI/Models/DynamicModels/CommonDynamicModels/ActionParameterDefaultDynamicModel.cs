using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class ActionParameterDefaultDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ActionParameterDefaultsDetailLevel? DetailLevel { get; set; }
}
