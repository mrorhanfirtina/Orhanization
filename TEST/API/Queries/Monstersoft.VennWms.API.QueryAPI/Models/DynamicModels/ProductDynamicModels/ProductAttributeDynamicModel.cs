using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductAttributeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductAttributesDetailLevel? DetailLevel { get; set; }
}

