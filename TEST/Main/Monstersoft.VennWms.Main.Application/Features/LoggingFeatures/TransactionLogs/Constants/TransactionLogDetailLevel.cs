namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Constants;

public class TransactionLogDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeUser { get; set; } = false;
    public bool IncludeLogStock { get; set; } = false;
    public TransactionLogLogStockDetailLevel LogStockDetailLevel { get; set; } = new TransactionLogLogStockDetailLevel();
    public class TransactionLogLogStockDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeFromLocation { get; set; } = false;
        public bool IncludeToLocation { get; set; } = false;
        public bool IncludeTransactionType { get; set; } = false;
        public bool IncludeLogStockAttributeValue { get; set; } = false;
        public TransactionLogLogStockAttributeDetailLevel LogStockAttributeDetailLevel { get; set; } = new TransactionLogLogStockAttributeDetailLevel();
        public class TransactionLogLogStockAttributeDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;
        }
        public bool IncludeLogStockContainer { get; set; } = false;
        public TransactionLogLogStockContainerDetailLevel LogStockContainerDetailLevel { get; set; } = new TransactionLogLogStockContainerDetailLevel();
        public class TransactionLogLogStockContainerDetailLevel
        {
            public bool IncludeFromContainerUnit { get; set; } = false;
            public bool IncludeToContainerUnit { get; set; } = false;
        }
        public bool IncludeLogStockUnsuitReason { get; set; } = false;
        public TransactionLogLogStockUnsuitReasonDetailLevel LogStockUnsuitReasonDetailLevel { get; set; } = new TransactionLogLogStockUnsuitReasonDetailLevel();
        public class TransactionLogLogStockUnsuitReasonDetailLevel
        {
            public bool IncludeFromReason { get; set; } = false;
            public bool IncludeToReason { get; set; } = false;
        }
        public bool IncludeLogStockReserveReason { get; set; } = false;
        public TransactionLogLogStockReserveReasonDetailLevel LogStockReserveReasonDetailLevel { get; set; } = new TransactionLogLogStockReserveReasonDetailLevel();
        public class TransactionLogLogStockReserveReasonDetailLevel
        {
            public bool IncludeFromReason { get; set; } = false;
            public bool IncludeToReason { get; set; } = false;
        }
    }
}
