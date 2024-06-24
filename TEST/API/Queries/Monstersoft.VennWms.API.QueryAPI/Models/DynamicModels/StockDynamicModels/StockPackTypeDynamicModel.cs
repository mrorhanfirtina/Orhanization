using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockPackTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockPackTypesDetailLevel? DetailLevel { get; set; }
}

