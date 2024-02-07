using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public decimal Quantity { get; set; }
    public int UnitId { get; set; }
    public virtual Order? Order { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Unit? Unit { get; set; }
    public virtual ICollection<OrderItemMemo> OrderItemMemos { get; set; }
    public virtual ICollection<OrderItemStockAttrValue> OrderItemStockAttrValues { get; set; }
    public virtual ICollection<OrderShipItem> OrderShipItems { get; set; }

    public OrderItem()
    {
        OrderItemMemos = new HashSet<OrderItemMemo>();
        OrderItemStockAttrValues = new HashSet<OrderItemStockAttrValue>();
        OrderShipItems = new HashSet<OrderShipItem>();
    }

    public OrderItem(Guid id, Guid orderId, Guid productId, decimal quantity, int unitId) : this()
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        UnitId = unitId;
    }
}
