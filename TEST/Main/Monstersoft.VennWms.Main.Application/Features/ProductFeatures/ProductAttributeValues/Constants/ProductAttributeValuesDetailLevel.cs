namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;

public class ProductAttributeValuesDetailLevel
{
    public bool IncludeProduct { get; set; } = false;
    public bool IncludeProductAttribute { get; set; } = false;
    public ProductAttributeValuesProductAttributeSubDetailLevel ProductAttributeDetailLevel { get; set; } = new ProductAttributeValuesProductAttributeSubDetailLevel();
    public class ProductAttributeValuesProductAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
