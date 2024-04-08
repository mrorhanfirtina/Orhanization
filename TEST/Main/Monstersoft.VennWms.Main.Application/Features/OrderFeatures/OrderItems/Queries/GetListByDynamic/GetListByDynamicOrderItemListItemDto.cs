using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Queries.GetListByDynamic;

public class GetListByDynamicOrderItemListItemDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Order Order { get; set; }
    public ICollection<OrderItemMemo> OrderItemMemos { get; set; }
    public ICollection<OrderItemStockAttrValue> OrderItemStockAttrValues { get; set; }
    public ICollection<OrderShipItem> OrderShipItems { get; set; }

}
