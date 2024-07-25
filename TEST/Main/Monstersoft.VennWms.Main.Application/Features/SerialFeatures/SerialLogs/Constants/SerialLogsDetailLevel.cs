namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Constants;

public class SerialLogsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeTransactionLog { get; set; } = false;
    public bool IncludeTransactionType { get; set; } = false;
    public bool IncludeReceipt { get; set; } = false;
}
