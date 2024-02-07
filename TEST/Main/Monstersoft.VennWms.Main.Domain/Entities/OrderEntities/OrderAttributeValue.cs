using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderAttributeValue : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }
    public virtual Order? Order { get; set; }
    public virtual OrderAttribute? OrderAttribute { get; set; }

    public OrderAttributeValue()
    {
    }

    public OrderAttributeValue(Guid id,Guid orderId, Guid orderAttributeId, string value) : this()
    {
        Id = id;
        OrderId = orderId;
        OrderAttributeId = orderAttributeId;
        Value = value;
    }
}
