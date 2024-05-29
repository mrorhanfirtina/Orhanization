namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;

public class ProductAttributeValueDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeProductAttribute { get; set; } = false;
    public ProductAttributeValueProductAttributeDetailLevel ProductAttributeDetailLevel { get; set; } = new ProductAttributeValueProductAttributeDetailLevel();
    public class ProductAttributeValueProductAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
