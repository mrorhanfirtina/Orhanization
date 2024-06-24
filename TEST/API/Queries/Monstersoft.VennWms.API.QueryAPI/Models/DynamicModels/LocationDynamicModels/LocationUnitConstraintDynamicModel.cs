using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationUnitConstraintDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationUnitConstraintsDetailLevel? DetailLevel { get; set; }
}

