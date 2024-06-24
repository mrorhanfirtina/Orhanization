using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class BuildingDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BuildingsDetailLevel? DetailLevel { get; set; }
}

