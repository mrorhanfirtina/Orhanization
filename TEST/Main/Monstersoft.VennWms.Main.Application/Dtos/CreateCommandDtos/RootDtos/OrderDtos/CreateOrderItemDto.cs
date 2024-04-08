using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

public class CreateOrderItemDto
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public ICollection<CreateOrderItemMemoSubDto> OrderItemMemos { get; set; }
    public ICollection<CreateOrderItemStockAttrValueSubDto> OrderItemStockAttrValues { get; set; }
    public ICollection<CreateOrderShipItemSubDto> OrderShipItems { get; set; }

}

