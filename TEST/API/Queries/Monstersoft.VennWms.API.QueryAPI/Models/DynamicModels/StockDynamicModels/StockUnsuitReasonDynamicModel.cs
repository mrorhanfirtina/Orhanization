using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockUnsuitReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockUnsuitReasonsDetailLevel? DetailLevel { get; set; }
}

