using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockAttributeValuesDetailLevel? DetailLevel { get; set; }
}

