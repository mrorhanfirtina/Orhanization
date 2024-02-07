using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.POEntities;

public class PoAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsNecessary { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<PoAttributeValue> PoAttributeValues { get; set; }

    public PoAttribute()
    {
        PoAttributeValues = new HashSet<PoAttributeValue>();
    }

    public PoAttribute(Guid id,string code, string description, int attributeInputTypeId, Guid depositorId, bool isNecessary) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        DepositorId = depositorId;
        IsNecessary = isNecessary;
    }
}
