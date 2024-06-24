using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockMemosDetailLevel? DetailLevel { get; set; }
}

