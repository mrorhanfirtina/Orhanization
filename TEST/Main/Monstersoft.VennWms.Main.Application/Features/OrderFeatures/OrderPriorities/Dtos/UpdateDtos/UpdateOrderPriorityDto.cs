namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderPriorityDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int PriorityId { get; set; }
}
