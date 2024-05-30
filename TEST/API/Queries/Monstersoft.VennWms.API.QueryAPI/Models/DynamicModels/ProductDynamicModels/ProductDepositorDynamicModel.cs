using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductDepositorDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductDepositorsDetailLevel? DetailLevel { get; set; }
}

