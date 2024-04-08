using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public Guid ItemUnitId { get; set; }
    public virtual ICollection<OrderItemMemo> OrderItemMemos { get; set; }
    public virtual ICollection<OrderItemStockAttrValue> OrderItemStockAttrValues { get; set; }
    public virtual ICollection<OrderShipItem> OrderShipItems { get; set; }
    public virtual Product Product { get; set; }
    public OrderItem()
    {
        OrderItemMemos = new HashSet<OrderItemMemo>();
        OrderItemStockAttrValues = new HashSet<OrderItemStockAttrValue>();
        OrderShipItems = new HashSet<OrderShipItem>();
    }

    public OrderItem(Guid id, Guid orderId, Guid productId, decimal quantity, Guid itemUnitId) : this()
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        ItemUnitId = itemUnitId;
    }
}
