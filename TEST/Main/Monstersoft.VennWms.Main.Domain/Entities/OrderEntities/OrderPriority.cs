using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderPriority : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public int PriorityId { get; set; }
    public virtual Order? Order { get; set; }
    public virtual PriorityList? Priority { get; set; }

    public OrderPriority()
    {
    }

    public OrderPriority(Guid id, Guid orderId, int priorityId) : this()
    {
        Id = id;
        OrderId = orderId;
        PriorityId = priorityId;
    }
}
