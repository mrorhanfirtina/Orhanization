using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductCategoryDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductCategoriesDetailLevel? DetailLevel { get; set; }
}

