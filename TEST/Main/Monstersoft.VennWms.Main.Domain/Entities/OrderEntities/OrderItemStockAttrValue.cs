using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderItemStockAttrValue : Entity<Guid>
{
    public Guid OrderItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public virtual OrderItem? OrderItem { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }

    public OrderItemStockAttrValue()
    {
    }

    public OrderItemStockAttrValue(Guid id, Guid orderItemId, Guid stockAttributeId, string value) : this()
    {
        Id = id;
        OrderItemId = orderItemId;
        StockAttributeId = stockAttributeId;
        Value = value;
    }
}
