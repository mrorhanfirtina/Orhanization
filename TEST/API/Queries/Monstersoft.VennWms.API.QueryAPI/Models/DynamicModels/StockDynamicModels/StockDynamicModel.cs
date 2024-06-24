using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StocksDetailLevel? DetailLevel { get; set; }
}

