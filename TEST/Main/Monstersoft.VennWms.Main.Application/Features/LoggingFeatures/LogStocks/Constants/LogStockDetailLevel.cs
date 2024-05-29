namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;

public class LogStockDetailLevel
{
    public bool IncludeTransactionLog { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeFromLocation { get; set; } = false;
    public bool IncludeToLocation { get; set; } = false;
    public bool IncludeTransactionType { get; set; } = false;
    public bool IncludeLogStockReserveReason { get; set; } = false;
    public bool IncludeLogStockAttributeValue { get; set; } = false;
    public LogStockLogStockAttributeDetailLevel LogStockAttributeDetailLevel { get; set; } = new LogStockLogStockAttributeDetailLevel();
    public class LogStockLogStockAttributeDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;
    }
    public bool IncludeLogStockContainer { get; set; } = false;
    public LogStockLogStockContainerDetailLevel LogStockContainerDetailLevel { get; set; } = new LogStockLogStockContainerDetailLevel();
    public class LogStockLogStockContainerDetailLevel
    {
        public bool IncludeFromContainerUnit { get; set; } = false;
        public bool IncludeToContainerUnit { get; set; } = false;
    }
    public bool IncludeLogLogStockUnsuitReason { get; set; } = false;
    public LogStockLogStockUnsuitReasonDetailLevel LogStockUnsuitReasonDetailLevel { get; set; } = new LogStockLogStockUnsuitReasonDetailLevel();
    public class LogStockLogStockUnsuitReasonDetailLevel
    {
        public bool IncludeFromReason { get; set; } = false;
        public bool IncludeToReason { get; set; } = false;
    }
    public bool IncludeLogLogStockReserveReason { get; set; } = false;
    public LogStockLogStockReserveReasonDetailLevel LogStockReserveReasonDetailLevel { get; set; } = new LogStockLogStockReserveReasonDetailLevel();
    public class LogStockLogStockReserveReasonDetailLevel
    {
        public bool IncludeFromReason { get; set; } = false;
        public bool IncludeToReason { get; set; } = false;
    }
}
