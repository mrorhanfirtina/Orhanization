using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public bool IsItemAttribte { get; set; }
    public Guid DepositorId { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<OrderAttributeValue> OrderAttributeValues { get; set; }

    public OrderAttribute()
    {
        OrderAttributeValues = new HashSet<OrderAttributeValue>();
    }

    public OrderAttribute(Guid id,string code, string description, int attributeInputTypeId, bool isNecessary, bool isItemAttribte, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        IsNecessary = isNecessary;
        IsItemAttribte = isItemAttribte;
        DepositorId = depositorId;
    }
}
