using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderTypesDetailLevel? DetailLevel { get; set; }
}

