namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;

public class ProductStockAttributesDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeStockAttribute { get; set; } = false;
    public ProductStockAttributesStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ProductStockAttributesStockAttributeSubDetailLevel();
    public class ProductStockAttributesStockAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
