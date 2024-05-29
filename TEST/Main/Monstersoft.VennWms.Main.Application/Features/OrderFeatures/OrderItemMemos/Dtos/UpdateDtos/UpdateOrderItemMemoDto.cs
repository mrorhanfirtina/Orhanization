namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.UpdateDtos;

public class UpdateOrderItemMemoDto
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }

}

