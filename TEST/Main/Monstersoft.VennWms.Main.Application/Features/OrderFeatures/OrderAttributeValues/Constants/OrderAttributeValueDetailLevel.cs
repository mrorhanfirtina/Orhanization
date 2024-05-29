namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;

public class OrderAttributeValueDetailLevel
{
    public bool IncludeOrder { get; set; } = false;
    public bool IncludeOrderAttribute { get; set; } = false;
    public OrderAttributeValueOrderAttributeDetailLevel OrderAttributeDetailLevel { get; set; } = new OrderAttributeValueOrderAttributeDetailLevel();
    public class OrderAttributeValueOrderAttributeDetailLevel
    {
        public bool IncludeAttributeInputType { get; set; } = false;
    }
}
