using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipItemTask : Entity<Guid>
{
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public virtual OrderShipItem? OrderShipItem { get; set; }
    public virtual ICollection<OrderShipItemStock> OrderShipItemStocks { get; set; }

    public OrderShipItemTask()
    {
        OrderShipItemStocks = new HashSet<OrderShipItemStock>();
    }

    public OrderShipItemTask(Guid id, Guid orderShipItemId, Guid workTaskId, decimal quantity) : this()
    {
        Id = id;
        OrderShipItemId = orderShipItemId;
        WorkTaskId = workTaskId;
        Quantity = quantity;
    }
}
