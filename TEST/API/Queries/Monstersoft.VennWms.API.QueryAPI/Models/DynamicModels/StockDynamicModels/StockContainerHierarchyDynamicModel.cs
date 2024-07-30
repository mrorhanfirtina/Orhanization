using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.StockDynamicModels;

public class StockContainerHierarchyDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StockContainerHierarchiesDetailLevel? DetailLevel { get; set; }
}
