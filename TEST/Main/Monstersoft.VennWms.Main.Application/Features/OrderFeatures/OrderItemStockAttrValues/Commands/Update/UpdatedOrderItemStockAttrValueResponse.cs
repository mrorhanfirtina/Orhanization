namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;

public class UpdatedOrderItemStockAttrValueResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
