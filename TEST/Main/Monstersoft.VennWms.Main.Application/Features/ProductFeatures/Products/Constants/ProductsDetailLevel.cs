namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;

public class ProductsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeProductStockAttribute { get; set; } = false;
    public bool IncludeProductDepositor { get; set; } = false;
    public bool IncludeProductBarcode { get; set; } = false;
    public bool IncludeProductAttributeValue { get; set; } = false;
    public bool IncludeProductCategory { get; set; } = false;
    public bool IncludeProductAbcCategory { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;

    public ProductsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ProductsItemUnitSubDetailLevel();
    public class ProductsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeItemPackType { get; set; } = false;
        public bool IncludeItemUnitConversion { get; set; } = false;
        public ProductsItemUnitConversionSubDetailLevel ItemUnitConversionDetailLevel { get; set; } = new ProductsItemUnitConversionSubDetailLevel();
        public class ProductsItemUnitConversionSubDetailLevel
        {
            public bool IncludeConvertedItemUnit { get; set; } = false;
            public ProductsConvertedItemUnitSubDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ProductsConvertedItemUnitSubDetailLevel();
            public class ProductsConvertedItemUnitSubDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }
        public ProductsItemPackTypeSubDetailLevel ItemPackTypeDetailLevel { get; set; } = new ProductsItemPackTypeSubDetailLevel();
        public class ProductsItemPackTypeSubDetailLevel
        {
            public bool IncludeLenghtUnit { get; set; } = false;
            public bool IncludeVolumeUnit { get; set; } = false;
            public bool IncludeWeightUnit { get; set; } = false;
        }
    }

    public ProductsProductAbcCategorySubDetailLevel ProductAbcCategoryDetailLevel { get; set; } = new ProductsProductAbcCategorySubDetailLevel();
    public class ProductsProductAbcCategorySubDetailLevel
    {
        public bool IncludeAbcCategoryList { get; set; } = false;
    }

    public ProductsProductAttributeValueSubDetailLevel ProductAttributeValueDetailLevel { get; set; } = new ProductsProductAttributeValueSubDetailLevel();
    public class ProductsProductAttributeValueSubDetailLevel
    {
        public bool IncludeProductAttribute { get; set; } = false;
        public ProductsProductAttributeSubDetailLevel ProductAttributeDetailLevel { get; set; } = new ProductsProductAttributeSubDetailLevel();
        public class ProductsProductAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public ProductsProductBarcodeSubDetailLevel ProductBarcodeDetailLevel { get; set; } = new ProductsProductBarcodeSubDetailLevel();
    public class ProductsProductBarcodeSubDetailLevel
    {
        public bool IncludeBarcodeSupplier { get; set; } = false;

        public ProductsBarcodeSupplierSubDetailLevel BarcodeSupplierDetailLevel { get; set; } = new ProductsBarcodeSupplierSubDetailLevel();
        public class ProductsBarcodeSupplierSubDetailLevel
        {
            public bool IncludeSupplier { get; set; } = false;

            public ProductsSupplierSubDetailLevel SupplierDetailLevel { get; set; } = new ProductsSupplierSubDetailLevel();
            public class ProductsSupplierSubDetailLevel
            {
                public bool IncludeCompany { get; set; } = false;
            }
        }
    }

    public ProductsProductCategorySubDetailLevel ProductCategoryDetailLevel { get; set; } = new ProductsProductCategorySubDetailLevel();
    public class ProductsProductCategorySubDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }

    public ProductsProductDepositorSubDetailLevel ProductDepositorDetailLevel { get; set; } = new ProductsProductDepositorSubDetailLevel();
    public class ProductsProductDepositorSubDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;

        public ProductsDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new ProductsDepositorSubDetailLevel();
        public class ProductsDepositorSubDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
    }

    public ProductsProductStockAttributeSubDetailLevel ProductStockAttributeDetailLevel { get; set; } = new ProductsProductStockAttributeSubDetailLevel();
    public class ProductsProductStockAttributeSubDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public ProductsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ProductsStockAttributeSubDetailLevel();
        public class ProductsStockAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

}
