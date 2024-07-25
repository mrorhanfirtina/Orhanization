using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class BufferLocationDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BufferLocationsDetailLevel? DetailLevel { get; set; }
}
