using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;

public class PoTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PoTypesDetailLevel? DetailLevel { get; set; }
}

