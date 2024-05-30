using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductStockAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductStockAttributesDetailLevel? DetailLevel { get; set; }
}

