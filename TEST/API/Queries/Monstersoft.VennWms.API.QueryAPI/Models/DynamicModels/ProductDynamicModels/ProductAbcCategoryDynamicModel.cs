using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductAbcCategoryDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductAbcCategoriesDetailLevel? DetailLevel { get; set; }
}

