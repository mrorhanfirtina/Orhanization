using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductAttributeValueDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductAttributeValuesDetailLevel? DetailLevel { get; set; }
}

