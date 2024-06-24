using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;

public class PoAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PoAttributesDetailLevel? DetailLevel { get; set; }
}

