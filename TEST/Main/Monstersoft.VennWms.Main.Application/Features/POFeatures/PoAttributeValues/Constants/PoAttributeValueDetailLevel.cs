namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;

public class PoAttributeValueDetailLevel
{
    public bool IncludePurchaseOrder { get; set; } = false;
    public bool IncludePoAttribute { get; set; } = false;
    public PoAttributeValuePoAttributeDetailLevel PoAttributeDetailLevel { get; set; } = new PoAttributeValuePoAttributeDetailLevel();
    public class PoAttributeValuePoAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
