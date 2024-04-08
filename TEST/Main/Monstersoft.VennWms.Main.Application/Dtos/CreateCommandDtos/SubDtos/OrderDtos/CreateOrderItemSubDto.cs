using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.OrderDtos;

public class CreateOrderItemSubDto
{
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public ICollection<CreateOrderItemMemoSubDto> OrderItemMemos { get; set; }
    public ICollection<CreateOrderItemStockAttrValueSubDto> OrderItemStockAttrValues { get; set; }
    public ICollection<CreateOrderShipItemSubDto> OrderShipItems { get; set; }

}

