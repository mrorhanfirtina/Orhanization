namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;

public class ProductStockAttributeDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeStockAttribute { get; set; } = false;
    public ProductStockAttributeStockAttributeDetailLevel StockAttributeDetailLevel { get; set; } = new ProductStockAttributeStockAttributeDetailLevel();
    public class ProductStockAttributeStockAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
