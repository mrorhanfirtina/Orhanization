using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;

public class SerialDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SerialsDetailLevel? DetailLevel { get; set; }
}
