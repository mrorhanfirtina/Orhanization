namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants;

public class ProductDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeProductStockAttribute { get; set; } = false;
    public bool IncludeProductDepositor { get; set; } = false;
    public bool IncludeProductBarcode { get; set; } = false;
    public bool IncludeProductAttributeValue { get; set; } = false;
    public bool IncludeProductCategory { get; set; } = false;
    public bool IncludeProductAbcCategory { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;

    public ProductItemUnitDetailLevel ItemUnitDetailLevel { get; set; } = new ProductItemUnitDetailLevel();
    public class ProductItemUnitDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeItemPackType { get; set; } = false;
        public bool IncludeItemUnitConversion { get; set; } = false;
        public ProductItemUnitConversiontDetailLevel ItemUnitConversionDetailLevel { get; set; } = new ProductItemUnitConversiontDetailLevel();
        public class ProductItemUnitConversiontDetailLevel
        {
            public bool IncludeConvertedItemUnit { get; set; } = false;
            public ProductConvertedItemUnitDetailLevel ConvertedItemUnitDetailLevel { get; set; } = new ProductConvertedItemUnitDetailLevel();
            public class ProductConvertedItemUnitDetailLevel
            {
                public bool IncludeUnit { get; set; } = false;
            }
        }
        public ProductItemPackTypeDetailLevel ItemPackTypeDetailLevel { get; set; } = new ProductItemPackTypeDetailLevel();
        public class ProductItemPackTypeDetailLevel
        {
            public bool IncludeLenghtUnit { get; set; } = false;
            public bool IncludeVolumeUnit { get; set; } = false;
            public bool IncludeWeightUnit { get; set; } = false;
        }
    }

    public ProductProductAbcCategoryDetailLevel ProductAbcCategoryDetailLevel { get; set; } = new ProductProductAbcCategoryDetailLevel();
    public class ProductProductAbcCategoryDetailLevel
    {
        public bool IncludeAbcCategoryList { get; set; } = false;
    }

    public ProductProductAttributeValueDetailLevel ProductAttributeValueDetailLevel { get; set; } = new ProductProductAttributeValueDetailLevel();
    public class ProductProductAttributeValueDetailLevel
    {
        public bool IncludeProductAttribute { get; set; } = false;
        public ProductProductAttributeDetailLevel ProductAttributeDetailLevel { get; set; } = new ProductProductAttributeDetailLevel();
        public class ProductProductAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

    public ProductProductBarcodeDetailLevel ProductBarcodeDetailLevel { get; set; } = new ProductProductBarcodeDetailLevel();
    public class ProductProductBarcodeDetailLevel
    {
        public bool IncludeBarcodeSupplier { get; set; } = false;

        public ProductBarcodeSupplierDetailLevel BarcodeSupplierDetailLevel { get; set; } = new ProductBarcodeSupplierDetailLevel();
        public class ProductBarcodeSupplierDetailLevel
        {
            public bool IncludeSupplier { get; set; } = false;

            public ProductSupplierDetailLevel SupplierDetailLevel { get; set; } = new ProductSupplierDetailLevel();
            public class ProductSupplierDetailLevel
            {
                public bool IncludeCompany { get; set; } = false;
            }
        }
    }

    public ProductProductCategoryDetailLevel ProductCategoryDetailLevel { get; set; } = new ProductProductCategoryDetailLevel();
    public class ProductProductCategoryDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }

    public ProductProductDepositorDetailLevel ProductDepositorDetailLevel { get; set; } = new ProductProductDepositorDetailLevel();
    public class ProductProductDepositorDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;

        public ProductDepositorDetailLevel DepositorDetailLevel { get; set; } = new ProductDepositorDetailLevel();
        public class ProductDepositorDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
    }

    public ProductProductStockAttributeDetailLevel ProductStockAttributeDetailLevel { get; set; } = new ProductProductStockAttributeDetailLevel();
    public class ProductProductStockAttributeDetailLevel
    {
        public bool IncludeStockAttribute { get; set; } = false;

        public ProductStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new ProductStockAttributeDetailLevel();
        public class ProductStockAttributeDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }

}
