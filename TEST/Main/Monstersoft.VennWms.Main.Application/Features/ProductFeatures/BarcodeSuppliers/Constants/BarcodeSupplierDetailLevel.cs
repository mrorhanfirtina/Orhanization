namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;

public class BarcodeSupplierDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeProductBarcode { get; set; } = false;
    public bool IncludeSupplier { get; set; } = false;
    public BarcodeSupplierSupplierDetailLevel SupplierDetailLevel { get; set; } = new BarcodeSupplierSupplierDetailLevel();
    public class BarcodeSupplierSupplierDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
