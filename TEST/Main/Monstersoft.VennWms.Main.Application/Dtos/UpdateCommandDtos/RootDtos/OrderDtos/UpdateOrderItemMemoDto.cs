namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderItemMemoDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }

}

