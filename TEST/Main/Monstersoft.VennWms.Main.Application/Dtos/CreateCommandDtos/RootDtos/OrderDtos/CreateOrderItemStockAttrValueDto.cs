namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

public class CreateOrderItemStockAttrValueDto
{
    public Guid OrderItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
}

