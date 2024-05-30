namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;

public class BarcodeSuppliersDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeProductBarcode { get; set; } = false;
    public bool IncludeSupplier { get; set; } = false;
    public BarcodeSuppliersSupplierSubDetailLevel SupplierDetailLevel { get; set; } = new BarcodeSuppliersSupplierSubDetailLevel();
    public class BarcodeSuppliersSupplierSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
