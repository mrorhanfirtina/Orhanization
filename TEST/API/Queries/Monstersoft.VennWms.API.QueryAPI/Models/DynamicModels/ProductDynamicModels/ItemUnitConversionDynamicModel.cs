using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ItemUnitConversionDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ItemUnitConversionsDetailLevel? DetailLevel { get; set; }
}

