using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAbcCategories.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationProductAbcCategoryDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationProductAbcCategoriesDetailLevel? DetailLevel { get; set; }
}

