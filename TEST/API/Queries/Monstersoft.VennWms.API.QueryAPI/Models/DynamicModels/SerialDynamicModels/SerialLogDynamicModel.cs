using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;

public class SerialLogDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SerialLogsDetailLevel? DetailLevel { get; set; }
}
