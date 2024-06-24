using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReceiptDynamicModels;

public class ReceiptTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiptTypesDetailLevel? DetailLevel { get; set; }
}

