namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Constants;

public class StockContainersDetailLevel
{
    public bool IncludeContainerUnit { get; set; } = false;
    public bool IncludeStock { get; set; } = false;
    public StockContainersStockSubDetailLevel StockDetailLevel { get; set; } = new StockContainersStockSubDetailLevel();
    public class StockContainersStockSubDetailLevel
    {
        public bool IncludeStockAttributeValue { get; set; } = false;
        public StockContainersStockAttributeValueSubDetailLevel StockAttributeValueDetailLevel { get; set; } = new StockContainersStockAttributeValueSubDetailLevel();
        public class StockContainersStockAttributeValueSubDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;
            public StockContainersStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new StockContainersStockAttributeSubDetailLevel();
            public class StockContainersStockAttributeSubDetailLevel
            {
                public bool IncludeAttributeInputType { get; set; } = false;
            }
        }
        public bool IncludeStockMemo { get; set; } = false;
        public bool IncludeStockReserveReason { get; set; } = false;
        public StockContainersStockReserveReasonSubDetailLevel StockReserveReasonDetailLevel { get; set; } = new StockContainersStockReserveReasonSubDetailLevel();
        public class StockContainersStockReserveReasonSubDetailLevel
        {
            public bool IncludeReserveReason { get; set; } = false;
        }

        public bool IncludeStockUnsuitReason { get; set; } = false;
        public StockContainersStockUnsuitReasonSubDetailLevel StockUnsuitReasonDetailLevel { get; set; } = new StockContainersStockUnsuitReasonSubDetailLevel();
        public class StockContainersStockUnsuitReasonSubDetailLevel
        {
            public bool IncludeUnsuitReason { get; set; } = false;
        }
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeDepositor { get; set; } = false;
        public StockContainersDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new StockContainersDepositorSubDetailLevel();
        public class StockContainersDepositorSubDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }

        public bool IncludeDepositorCompany { get; set; } = false;
        public bool IncludeLocation { get; set; } = false;
        public bool IncludeCuItemUnit { get; set; } = false;
        public StockContainersCuItemUnitSubDetailLevel CuItemUnitDetailLevel { get; set; } = new StockContainersCuItemUnitSubDetailLevel();
        public class StockContainersCuItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }

}
