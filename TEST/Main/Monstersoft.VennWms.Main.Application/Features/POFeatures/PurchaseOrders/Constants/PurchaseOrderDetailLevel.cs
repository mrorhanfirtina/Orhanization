namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Constants;

public class PurchaseOrderDetailLevel
{
    public bool IncludeStatus { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludePoMemo { get; set; } = false;
    public bool IncludePoType { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public PurchaseOrderDepositorDetailLevel DepositorDetailLevel { get; set; } = new PurchaseOrderDepositorDetailLevel();
    public class PurchaseOrderDepositorDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
    public bool IncludeReceipt { get; set; } = false;
    public PurchaseOrderReceiptDetailLevel ReceiptDetailLevel { get; set; } = new PurchaseOrderReceiptDetailLevel();
    public class PurchaseOrderReceiptDetailLevel
    {
        public bool IncludeStatus { get; set; } = false;
    }
    public bool IncludeSupplier { get; set; } = false;
    public PurchaseOrderSupplierDetailLevel SupplierDetailLevel { get; set; } = new PurchaseOrderSupplierDetailLevel();
    public class PurchaseOrderSupplierDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
        public bool IncludeAddress { get; set; } = false;
    }
    public bool IncludePoAttributeValue { get; set; } = false;
    public PurchaseOrderPoAttributeValueDetailLevel PoAttributeValueDetailLevel { get; set; } = new PurchaseOrderPoAttributeValueDetailLevel();
    public class PurchaseOrderPoAttributeValueDetailLevel
    {
        public bool IncludePoAttribute { get; set; } = false;
        public PurchaseOrderPoAttributeValuePoAttributeDetailLevel PoAttributeDetailLevel { get; set; } = new PurchaseOrderPoAttributeValuePoAttributeDetailLevel();
        public class PurchaseOrderPoAttributeValuePoAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
}