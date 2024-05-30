using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnAttributesDetailLevel? DetailLevel { get; set; }
}

