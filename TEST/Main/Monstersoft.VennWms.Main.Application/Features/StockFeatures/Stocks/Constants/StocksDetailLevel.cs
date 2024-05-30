namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;

public class StocksDetailLevel
{
    public bool IncludeStockAttributeValue { get; set; } = false;
    public StocksStockAttributeValueSubDetailLevel StockAttributeValueDetailLevel { get; set; } = new StocksStockAttributeValueSubDetailLevel();
    public class StocksStockAttributeValueSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;
        public StocksStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new StocksStockAttributeSubDetailLevel();
        public class StocksStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public bool IncludeStockMemo { get; set; } = false;
    public bool IncludeStockReserveReason { get; set; } = false;
    public StocksStockReserveReasonSubDetailLevel StockReserveReasonDetailLevel { get; set; } = new StocksStockReserveReasonSubDetailLevel();
    public class StocksStockReserveReasonSubDetailLevel
    {
        public bool IncludeReserveReason { get; set; } = false;
    }
    public bool IncludeStockUnsuitReason { get; set; } = false;
    public StocksStockUnsuitReasonSubDetailLevel StockUnsuitReasonDetailLevel { get; set; } = new StocksStockUnsuitReasonSubDetailLevel();
    public class StocksStockUnsuitReasonSubDetailLevel
    {
        public bool IncludeUnsuitReason { get; set; } = false;
    }
    public bool IncludeStockInbound { get; set; } = false;
    public StocksStockInboundSubDetailLevel StockInboundDetailLevel { get; set; } = new StocksStockInboundSubDetailLevel();
    public class StocksStockInboundSubDetailLevel
    {
        public bool IncludeReceipt { get; set; } = false;
        public bool IncludeReturn { get; set; } = false;
    }
    public bool IncludeStockPackType { get; set; } = false;
    public StocksStockPackTypeSubDetailLevel StockPackTypeDetailLevel { get; set; } = new StocksStockPackTypeSubDetailLevel();
    public class StocksStockPackTypeSubDetailLevel
    {
        public bool IncludeItemUnit { get; set; } = false;
        public StocksItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new StocksItemUnitSubDetailLevel();
        public class StocksItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }

    public bool IncludeProduct { get; set; } = false;
    public StocksProductSubDetailLevel ProductDetailLevel { get; set; } = new StocksProductSubDetailLevel();
    public class StocksProductSubDetailLevel
    {
        public bool IncludeProductBarcode { get; set; } = false;
    }

    public bool IncludeDepositor { get; set; } = false;
    public StocksDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new StocksDepositorSubDetailLevel();
    public class StocksDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeLocation { get; set; } = false;


    public bool IncludeCuItemUnit { get; set; } = false;
    public StockItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new StockItemUnitSubDetailLevel();
    public class StockItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeItemPackType { get; set; } = false;
        public StocksItemPackTypeSubDetailLevel ItemPackTypeDetailLevel { get; set; } = new StocksItemPackTypeSubDetailLevel();
        public class StocksItemPackTypeSubDetailLevel
        {
            public bool IncludeLenghtUnit { get; set; } = false;
            public bool IncludeVolumeUnit { get; set; } = false;
            public bool IncludeWeightUnit { get; set; } = false;
            public bool IncludeItemUnit { get; set; } = false;
            public StocksCuItemUnitSubDetailLevel CuItemUnitDetailLevel { get; set; } = new StocksCuItemUnitSubDetailLevel();
            public class StocksCuItemUnitSubDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }
    }
    public bool IncludeStockContainer { get; set; } = false;
    public StocksStockContainerSubDetailLevel StockContainerDetailLevel { get; set; } = new StocksStockContainerSubDetailLevel();
    public class StocksStockContainerSubDetailLevel
    {
        public bool IncludeContainerUnit { get; set; } = false;
    }
}
