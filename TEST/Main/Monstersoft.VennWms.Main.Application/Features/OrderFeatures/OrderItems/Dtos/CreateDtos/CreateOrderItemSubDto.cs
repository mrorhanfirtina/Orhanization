using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.CreateDtos;

public class CreateOrderItemSubDto
{
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public ICollection<CreateOrderItemMemoSubDto> OrderItemMemos { get; set; }
    public ICollection<CreateOrderItemStockAttrValueSubDto> OrderItemStockAttrValues { get; set; }
    public ICollection<CreateOrderShipItemSubDto> OrderShipItems { get; set; }

}

