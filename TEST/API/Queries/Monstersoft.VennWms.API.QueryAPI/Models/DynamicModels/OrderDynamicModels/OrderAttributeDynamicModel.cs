using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderAttributesDetailLevel? DetailLevel { get; set; }
}

