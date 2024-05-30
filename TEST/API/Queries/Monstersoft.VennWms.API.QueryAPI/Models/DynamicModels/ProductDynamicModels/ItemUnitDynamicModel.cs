using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ItemUnitDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ItemUnitsDetailLevel? DetailLevel { get; set; }
}

