using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockReserveReasonDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockReserveReasonsDetailLevel? DetailLevel { get; set; }
}

