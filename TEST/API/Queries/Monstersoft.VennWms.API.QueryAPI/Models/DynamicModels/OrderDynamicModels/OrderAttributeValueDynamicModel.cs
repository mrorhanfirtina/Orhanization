using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderAttributeValuesDetailLevel? DetailLevel { get; set; }
}

