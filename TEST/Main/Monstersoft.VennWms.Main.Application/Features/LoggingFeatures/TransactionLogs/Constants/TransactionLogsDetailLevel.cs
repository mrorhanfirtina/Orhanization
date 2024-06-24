namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;

public class TransactionLogsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeUser { get; set; } = false;
    public bool IncludeLogStock { get; set; } = false;
    public TransactionLogsLogStockSubDetailLevel LogStockDetailLevel { get; set; } = new TransactionLogsLogStockSubDetailLevel();
    public class TransactionLogsLogStockSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeFromLocation { get; set; } = false;
        public bool IncludeToLocation { get; set; } = false;
        public bool IncludeTransactionType { get; set; } = false;
        public bool IncludeLogStockAttributeValue { get; set; } = false;
        public TransactionLogsLogStockAttributeSubDetailLevel LogStockAttributeDetailLevel { get; set; } = new TransactionLogsLogStockAttributeSubDetailLevel();
        public class TransactionLogsLogStockAttributeSubDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;
        }
        public bool IncludeLogStockContainer { get; set; } = false;
        public TransactionLogsLogStockContainerSubDetailLevel LogStockContainerDetailLevel { get; set; } = new TransactionLogsLogStockContainerSubDetailLevel();
        public class TransactionLogsLogStockContainerSubDetailLevel
        {
            public bool IncludeFromContainerUnit { get; set; } = false;
            public bool IncludeToContainerUnit { get; set; } = false;
        }
        public bool IncludeLogStockUnsuitReason { get; set; } = false;
        public TransactionLogsLogStockUnsuitReasonSubDetailLevel LogStockUnsuitReasonDetailLevel { get; set; } = new TransactionLogsLogStockUnsuitReasonSubDetailLevel();
        public class TransactionLogsLogStockUnsuitReasonSubDetailLevel
        {
            public bool IncludeFromReason { get; set; } = false;
            public bool IncludeToReason { get; set; } = false;
        }
        public bool IncludeLogStockReserveReason { get; set; } = false;
        public TransactionLogsLogStockReserveReasonSubDetailLevel LogStockReserveReasonDetailLevel { get; set; } = new TransactionLogsLogStockReserveReasonSubDetailLevel();
        public class TransactionLogsLogStockReserveReasonSubDetailLevel
        {
            public bool IncludeFromReason { get; set; } = false;
            public bool IncludeToReason { get; set; } = false;
        }
    }
}
