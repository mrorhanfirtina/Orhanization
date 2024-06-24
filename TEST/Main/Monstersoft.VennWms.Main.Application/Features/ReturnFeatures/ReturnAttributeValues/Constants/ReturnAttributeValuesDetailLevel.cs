namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;

public class ReturnAttributeValuesDetailLevel
{
    public bool IncludeReturn { get; set; } = false;
    public bool IncludeReturnAttribute { get; set; } = false;
    public ReturnAttributeValuesReturnAttributeSubDetailLevel ReturnAttributeDetailLevel { get; set; } = new ReturnAttributeValuesReturnAttributeSubDetailLevel();
    public class ReturnAttributeValuesReturnAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
