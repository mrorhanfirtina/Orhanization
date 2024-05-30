using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.PurchaseOrderDynamicModels;

public class PoMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PoMemosDetailLevel? DetailLevel { get; set; }
}

