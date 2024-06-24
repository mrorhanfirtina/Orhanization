using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class UnitConversionDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public UnitConversionsDetailLevel? DetailLevel { get; set; }
}

