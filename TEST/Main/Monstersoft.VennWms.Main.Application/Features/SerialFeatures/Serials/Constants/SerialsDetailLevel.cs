namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;

public class SerialsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeReceipt { get; set; } = false;
    public bool IncludeReceiptItem { get; set; } = false;
    public bool IncludeSerialHiearchy { get; set; } = false;
    public SerialSerialHiearchySubDetailLevel SerialHiearchyDetailLevel { get; set; } = new SerialSerialHiearchySubDetailLevel();
    public class SerialSerialHiearchySubDetailLevel
    {
        public bool IncludeChildSerial { get; set; } = false;
    }

    public bool IncludeStockPackType { get; set; } = false;
    public SerialStockPackTypeSubDetailLevel StockPackTypeDetailLevel { get; set; } = new SerialStockPackTypeSubDetailLevel();
    public class SerialStockPackTypeSubDetailLevel
    {
        public bool IncludeItemUnit { get; set; } = false;
        public SerialItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new SerialItemUnitSubDetailLevel();
        public class SerialItemUnitSubDetailLevel
        {
            public bool IncludeProduct { get; set; } = false;
            public bool IncludeUnit { get; set; } = false;
        }
        public bool IncludeStock { get; set; } = false;

        public SerialStockSubDetailLevel StockDetailLevel { get; set; } = new SerialStockSubDetailLevel();
        public class SerialStockSubDetailLevel
        {
            public bool IncludeLocation { get; set; } = false;
            public bool IncludeStockContainer { get; set; } = false;
        }
    }
}
