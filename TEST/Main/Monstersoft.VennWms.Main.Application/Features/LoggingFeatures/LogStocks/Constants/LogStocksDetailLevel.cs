namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;

public class LogStocksDetailLevel
{
    public bool IncludeTransactionLog { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeFromLocation { get; set; } = false;
    public bool IncludeToLocation { get; set; } = false;
    public bool IncludeTransactionType { get; set; } = false;
    public bool IncludeLogStockReserveReason { get; set; } = false;
    public bool IncludeLogStockAttributeValue { get; set; } = false;
    public LogStocksLogStockAttributeSubDetailLevel LogStockAttributeDetailLevel { get; set; } = new LogStocksLogStockAttributeSubDetailLevel();
    public class LogStocksLogStockAttributeSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;
    }
    public bool IncludeLogStockContainer { get; set; } = false;
    public LogStocksLogStockContainerSubDetailLevel LogStockContainerDetailLevel { get; set; } = new LogStocksLogStockContainerSubDetailLevel();
    public class LogStocksLogStockContainerSubDetailLevel
    {
        public bool IncludeFromContainerUnit { get; set; } = false;
        public bool IncludeToContainerUnit { get; set; } = false;
    }
    public bool IncludeLogLogStockUnsuitReason { get; set; } = false;
    public LogStocksLogStockUnsuitReasonSubDetailLevel LogStockUnsuitReasonDetailLevel { get; set; } = new LogStocksLogStockUnsuitReasonSubDetailLevel();
    public class LogStocksLogStockUnsuitReasonSubDetailLevel
    {
        public bool IncludeFromReason { get; set; } = false;
        public bool IncludeToReason { get; set; } = false;
    }
    public bool IncludeLogLogStockReserveReason { get; set; } = false;
    public LogStocksLogStockReserveReasonSubDetailLevel LogStockReserveReasonDetailLevel { get; set; } = new LogStocksLogStockReserveReasonSubDetailLevel();
    public class LogStocksLogStockReserveReasonSubDetailLevel
    {
        public bool IncludeFromReason { get; set; } = false;
        public bool IncludeToReason { get; set; } = false;
    }
}
