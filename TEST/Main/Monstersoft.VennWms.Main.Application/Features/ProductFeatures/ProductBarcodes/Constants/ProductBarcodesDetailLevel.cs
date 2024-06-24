namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;

public class ProductBarcodesDetailLevel
{
    public bool IncludeItemUnit { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeBarcodeSupplier { get; set; } = false;
    public ProductBarcodesBarcodeSupplierSubDetailLevel BarcodeSupplierDetailLevel { get; set; } = new ProductBarcodesBarcodeSupplierSubDetailLevel();
    public class ProductBarcodesBarcodeSupplierSubDetailLevel
    {
        public bool IncludeSupplier { get; set; } = false;

        public ProductBarcodesSupplierSubDetailLevel SupplierDetailLevel { get; set; } = new ProductBarcodesSupplierSubDetailLevel();
        public class ProductBarcodesSupplierSubDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
    }
}
