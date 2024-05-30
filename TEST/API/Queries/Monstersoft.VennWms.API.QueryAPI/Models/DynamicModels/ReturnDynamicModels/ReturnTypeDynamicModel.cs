using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnTypesDetailLevel? DetailLevel { get; set; }
}

