using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LoggingDynamicModels;

public class LogStockDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LogStocksDetailLevel? DetailLevel { get; set; }
}

