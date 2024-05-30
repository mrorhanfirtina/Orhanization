using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptAttributesDetailLevel? DetailLevel { get; set; }
}

