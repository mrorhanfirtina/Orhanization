using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptItemDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptItemsDetailLevel? DetailLevel { get; set; }
}

