using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockAttributesDetailLevel? DetailLevel { get; set; }
}

