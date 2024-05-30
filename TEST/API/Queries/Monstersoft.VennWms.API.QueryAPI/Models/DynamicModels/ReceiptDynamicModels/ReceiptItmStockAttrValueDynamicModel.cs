using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptItmStockAttrValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptItmStockAttrValuesDetailLevel? DetailLevel { get; set; }
}

