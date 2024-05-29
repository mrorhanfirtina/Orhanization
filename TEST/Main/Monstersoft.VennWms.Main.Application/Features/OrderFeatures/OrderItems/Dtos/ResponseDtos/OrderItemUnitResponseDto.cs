using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.ResponseDtos;

public class OrderItemUnitResponseDto
{
    public Guid Id { get; set; }
    public int UnitId { get; set; }
    public OrderUnitResponseDto? Unit { get; set; }

}
