using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationProductConstraintDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationProductConstraintsDetailLevel? DetailLevel { get; set; }
}

