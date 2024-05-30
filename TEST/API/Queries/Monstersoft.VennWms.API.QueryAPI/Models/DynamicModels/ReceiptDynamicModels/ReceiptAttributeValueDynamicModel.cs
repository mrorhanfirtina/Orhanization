using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptAttributeValuesDetailLevel? DetailLevel { get; set; }
}

