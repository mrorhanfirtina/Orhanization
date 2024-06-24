using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptItemMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptItemMemosDetailLevel? DetailLevel { get; set; }
}

