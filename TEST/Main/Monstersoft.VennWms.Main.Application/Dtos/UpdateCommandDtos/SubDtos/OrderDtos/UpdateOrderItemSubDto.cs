using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

public class UpdateOrderItemSubDto
{
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public ICollection<UpdateOrderItemMemoSubDto> OrderItemMemos { get; set; }
    public ICollection<UpdateOrderItemStockAttrValueSubDto> OrderItemStockAttrValues { get; set; }
    public ICollection<UpdateOrderShipItemSubDto> OrderShipItems { get; set; }

}

