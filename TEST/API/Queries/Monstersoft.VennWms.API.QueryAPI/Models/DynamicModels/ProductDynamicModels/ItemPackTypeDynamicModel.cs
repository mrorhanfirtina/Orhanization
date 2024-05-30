using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ItemPackTypeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ItemPackTypesDetailLevel? DetailLevel { get; set; }
}

