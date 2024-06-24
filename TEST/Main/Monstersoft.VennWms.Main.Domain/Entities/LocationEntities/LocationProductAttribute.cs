using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProductAttribute : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
    public virtual ProductAttribute? ProductAttribute { get; set; }
    public virtual Location? Location { get; set; }
    public LocationProductAttribute()
    {
    }

    public LocationProductAttribute(Guid locationId, Guid productAttributeId, bool isForbid) : this()
    {
        LocationId = locationId;
        ProductAttributeId = productAttributeId;
        IsForbid = isForbid;
    }
}
