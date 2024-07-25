using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class ActionParameterCategoryDynamicModel
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ActionParameterCategoryDetailLevel? DetailLevel { get; set; }
}
