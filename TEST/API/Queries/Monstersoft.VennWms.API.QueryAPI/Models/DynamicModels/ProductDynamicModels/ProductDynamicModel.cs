using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductsDetailLevel? DetailLevel { get; set; }
}

