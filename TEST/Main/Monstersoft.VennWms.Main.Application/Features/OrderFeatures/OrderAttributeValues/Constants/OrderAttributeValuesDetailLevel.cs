namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;

public class OrderAttributeValuesDetailLevel
{
    public bool IncludeOrder { get; set; } = false;
    public bool IncludeOrderAttribute { get; set; } = false;
    public OrderAttributeValuesOrderAttributeSubDetailLevel OrderAttributeDetailLevel { get; set; } = new OrderAttributeValuesOrderAttributeSubDetailLevel();
    public class OrderAttributeValuesOrderAttributeSubDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
