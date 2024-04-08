namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderItemStockAttrValueDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

