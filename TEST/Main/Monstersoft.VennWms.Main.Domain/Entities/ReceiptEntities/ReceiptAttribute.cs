using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class ReceiptAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsNecessary { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<ReceiptAttributeValue> ReceiptAttributeValues { get; set; }

    public ReceiptAttribute()
    {
        ReceiptAttributeValues = new HashSet<ReceiptAttributeValue>();
    }

    public ReceiptAttribute(Guid id, string code, string description, int attributeInputTypeId, Guid depositorId, bool isNecessary) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        DepositorId = depositorId;
        IsNecessary = isNecessary;
    }
}
