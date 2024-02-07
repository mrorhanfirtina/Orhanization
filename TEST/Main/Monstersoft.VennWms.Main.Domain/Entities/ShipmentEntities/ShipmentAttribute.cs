using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

public class ShipmentAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorId { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<ShipmentAttributeValue> ShipmentAttributeValues { get; set; }

    public ShipmentAttribute()
    {
        ShipmentAttributeValues = new HashSet<ShipmentAttributeValue>();
    }

    public ShipmentAttribute(string code, string description, int attributeInputTypeId, bool isNecessary, Guid depositorId) : this()
    {
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        IsNecessary = isNecessary;
        DepositorId = depositorId;
    }
}
