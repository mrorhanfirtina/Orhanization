using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptsDetailLevel? DetailLevel { get; set; }
}

