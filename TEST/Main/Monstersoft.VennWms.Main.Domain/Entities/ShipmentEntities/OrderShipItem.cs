using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class OrderShipItem : Entity<Guid>
{
    public Guid OrderItemId { get; set; }
    public Guid OrderShipmentId { get; set; }
    public Guid ProgressStatusId { get; set; }
    public decimal Quantity { get; set; }
    public virtual OrderItem? OrderItem { get; set; }
    public virtual ProgressStatus? ProgressStatus { get; set; }
    public virtual ICollection<OrderShipItemTask> OrderShipItemTasks { get; set; }

    public OrderShipItem()
    {
        OrderShipItemTasks = new HashSet<OrderShipItemTask>();
    }

    public OrderShipItem(Guid id, Guid orderItemId, Guid orderShipmentId, Guid progressStatusId, decimal quantity) : this()
    {
        Id = id;
        OrderItemId = orderItemId;
        OrderShipmentId = orderShipmentId;
        ProgressStatusId = progressStatusId;
        Quantity = quantity;
    }
}
