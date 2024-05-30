using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockContainerDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockContainersDetailLevel? DetailLevel { get; set; }
}

