using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnAttributeValuesDetailLevel? DetailLevel { get; set; }
}

