using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductCategoryListDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductCategoryListsDetailLevel? DetailLevel { get; set; }
}

