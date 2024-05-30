using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockInboundDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockInboundsDetailLevel? DetailLevel { get; set; }
}

