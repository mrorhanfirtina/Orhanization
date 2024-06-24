using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.UpdateDtos;

public class UpdateOrderItemSubDto
{
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public ICollection<UpdateOrderItemMemoSubDto> OrderItemMemos { get; set; }
    public ICollection<UpdateOrderItemStockAttrValueSubDto> OrderItemStockAttrValues { get; set; }
    public ICollection<UpdateOrderShipItemSubDto> OrderShipItems { get; set; }

}

