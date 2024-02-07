using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ProductAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public Guid DepositorId { get; set; }
    public virtual AttributeInputType? AttributeInputType { get; set; }
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }

    public ProductAttribute()
    {
        ProductAttributeValues = new HashSet<ProductAttributeValue>();
    }

    public ProductAttribute(Guid id, string code, string description, int attributeInputTypeId, bool isNecessary, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        IsNecessary = isNecessary;
        DepositorId = depositorId;
    }
}
