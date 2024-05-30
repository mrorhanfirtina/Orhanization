using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class TaskStockDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public TaskStocksDetailLevel? DetailLevel { get; set; }
}

