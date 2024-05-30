namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;

public class ReceiptsDetailLevel
{
    public bool IncludeReceiptType { get; set; } = false;
    public bool IncludePurchaseOrder { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeStatus { get; set; } = false;

    public bool IncludeSupplier { get; set; } = false;
    public ReceiptsSupplierSubDetailLevel SupplierDetailLevel { get; set; } = new ReceiptsSupplierSubDetailLevel();
    public class ReceiptsSupplierSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeReceiptAttributeValue { get; set; } = false;
    public ReceiptsReceiptAttributeSubDetailLevel ReceiptAttributeDetailLevel { get; set; } = new ReceiptsReceiptAttributeSubDetailLevel();
    public class ReceiptsReceiptAttributeSubDetailLevel
    {
        public bool ReceiptAttribute { get; set; } = false;
    }
    public bool IncludeReceiptMemo { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public ReceiptsDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new ReceiptsDepositorSubDetailLevel();
    public class ReceiptsDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
    public bool IncludeReceiptItem { get; set; } = false;
    public ReceiptsReceiptItemSubDetailLevel ReceiptItemDetailLevel { get; set; } = new ReceiptsReceiptItemSubDetailLevel();
    public class ReceiptsReceiptItemSubDetailLevel
    {
        public bool IncludeStatus { get; set; } = false;
        public bool IncludeReceiptItemMemo { get; set; } = false;
        public bool IncludeReceiptItmStockAttrValue { get; set; } = false;
        public ReceiptsReceiptItmStockAttrValueSubDetailLevel ReceiptItmStockAttrValueDetailLevel { get; set; } = new ReceiptsReceiptItmStockAttrValueSubDetailLevel();
        public class ReceiptsReceiptItmStockAttrValueSubDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;

            public ReceiptsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReceiptsStockAttributeSubDetailLevel();
            public class ReceiptsStockAttributeSubDetailLevel
            {
                public bool IncludeAttributeInputType { get; set; } = false;
            }
        }
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeItemUnit { get; set; } = false;
        public ReceiptsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ReceiptsItemUnitSubDetailLevel();
        public class ReceiptsItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }

}
