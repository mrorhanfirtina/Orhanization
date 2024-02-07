using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipItemStock : Entity<Guid>
{
    public Guid OrderShipItemId { get; set; }
    public Guid OrderShipItemTaskId { get; set; }
    public Guid StockId { get; set; }
    public decimal Quantity { get; set; }
    public virtual OrderShipItemTask? OrderShipItemTask { get; set; }

    public OrderShipItemStock()
    {
    }

    public OrderShipItemStock(Guid id, Guid orderShipItemId, Guid orderShipItemTaskId, Guid stockId, decimal quantity) : this()
    {
        Id = id;
        OrderShipItemId = orderShipItemId;
        OrderShipItemTaskId = orderShipItemTaskId;
        StockId = stockId;
        Quantity = quantity;
    }
}
