using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class LocationCodeFormatDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public LocationCodeFormatsDetailLevel? DetailLevel { get; set; }
}

