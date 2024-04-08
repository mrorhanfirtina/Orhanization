namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderMemoDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

