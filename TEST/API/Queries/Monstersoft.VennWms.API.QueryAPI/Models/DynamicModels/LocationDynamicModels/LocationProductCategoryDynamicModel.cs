using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductCategories.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationProductCategoryDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationProductCategoriesDetailLevel? DetailLevel { get; set; }
}

