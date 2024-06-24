using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnItmStockAttrValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnItmStockAttrValuesDetailLevel? DetailLevel { get; set; }
}

