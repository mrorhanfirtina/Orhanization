using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class BuildingDimensionDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BuildingDimensionsDetailLevel? DetailLevel { get; set; }
}

