using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LoggingDynamicModels;

public class TransactionLogDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public TransactionLogsDetailLevel? DetailLevel { get; set; }
}

