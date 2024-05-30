using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;

public class PoAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PoAttributeValuesDetailLevel? DetailLevel { get; set; }
}

