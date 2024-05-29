namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

public class OrderItemItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public OrderItemUnitResponseDto? Unit { get; set; }
}
