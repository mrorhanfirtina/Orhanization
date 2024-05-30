using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class UnitDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public UnitsDetailLevel? DetailLevel { get; set; }
}

