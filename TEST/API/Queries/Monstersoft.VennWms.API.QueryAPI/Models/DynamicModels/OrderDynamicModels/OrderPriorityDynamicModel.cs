using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderPriorityDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderPrioritiesDetailLevel? DetailLevel { get; set; }
}

