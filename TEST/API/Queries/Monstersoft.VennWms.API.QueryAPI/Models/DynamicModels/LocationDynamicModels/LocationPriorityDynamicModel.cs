using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationPriorityDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationPrioritiesDetailLevel? DetailLevel { get; set; }
}

