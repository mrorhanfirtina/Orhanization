namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;

public class PurchaseOrdersDetailLevel
{
    public bool IncludeStatus { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludePoMemo { get; set; } = false;
    public bool IncludePoType { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public PurchaseOrdersDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new PurchaseOrdersDepositorSubDetailLevel();
    public class PurchaseOrdersDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
    public bool IncludeReceipt { get; set; } = false;
    public PurchaseOrdersReceiptSubDetailLevel ReceiptDetailLevel { get; set; } = new PurchaseOrdersReceiptSubDetailLevel();
    public class PurchaseOrdersReceiptSubDetailLevel
    {
        public bool IncludeStatus { get; set; } = false;
    }
    public bool IncludeSupplier { get; set; } = false;
    public PurchaseOrdersSupplierSubDetailLevel SupplierDetailLevel { get; set; } = new PurchaseOrdersSupplierSubDetailLevel();
    public class PurchaseOrdersSupplierSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
        public bool IncludeAddress { get; set; } = false;
    }
    public bool IncludePoAttributeValue { get; set; } = false;
    public PurchaseOrdersPoAttributeValueSubDetailLevel PoAttributeValueDetailLevel { get; set; } = new PurchaseOrdersPoAttributeValueSubDetailLevel();
    public class PurchaseOrdersPoAttributeValueSubDetailLevel
    {
        public bool IncludePoAttribute { get; set; } = false;
        public PurchaseOrdersPoAttributeSubDetailLevel PoAttributeDetailLevel { get; set; } = new PurchaseOrdersPoAttributeSubDetailLevel();
        public class PurchaseOrdersPoAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
}