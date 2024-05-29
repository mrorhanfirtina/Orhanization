namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;

public class ProductBarcodeDetailLevel
{
    public bool IncludeItemUnit { get; set; } = false;
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeBarcodeSupplier { get; set; } = false;
    public ProductBarcodeBarcodeSupplierDetailLevel BarcodeSupplierDetailLevel { get; set; } = new ProductBarcodeBarcodeSupplierDetailLevel();
    public class ProductBarcodeBarcodeSupplierDetailLevel
    {
        public bool IncludeSupplier { get; set; } = false;

        public ProductBarcodeSupplierDetailLevel SupplierDetailLevel { get; set; } = new ProductBarcodeSupplierDetailLevel();
        public class ProductBarcodeSupplierDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
    }
}
