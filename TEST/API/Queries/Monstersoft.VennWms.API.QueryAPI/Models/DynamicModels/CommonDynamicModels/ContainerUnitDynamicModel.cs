using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class ContainerUnitDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ContainerUnitsDetaillevel? DetailLevel { get; set; }
}

