using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptMemosDetailLevel? DetailLevel { get; set; }
}

