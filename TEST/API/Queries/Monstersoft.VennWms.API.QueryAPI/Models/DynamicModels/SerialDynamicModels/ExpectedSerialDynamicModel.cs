using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;

public class ExpectedSerialDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ExpectedSerialsDetailLevel? DetailLevel { get; set; }
}
