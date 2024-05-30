namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;

public class PoAttributeValuesDetailLevel
{
    public bool IncludePurchaseOrder { get; set; } = false;
    public bool IncludePoAttribute { get; set; } = false;
    public PoAttributeValuesPoAttributeSubDetailLevel PoAttributeDetailLevel { get; set; } = new PoAttributeValuesPoAttributeSubDetailLevel();
    public class PoAttributeValuesPoAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
