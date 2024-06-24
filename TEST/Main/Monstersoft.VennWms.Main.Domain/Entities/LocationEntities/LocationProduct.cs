using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProduct : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Location? Location { get; set; }
    public LocationProduct()
    {
    }

    public LocationProduct(Guid locationId, Guid productId, bool isForbid) : this()
    {
        LocationId = locationId;
        ProductId = productId;
        IsForbid = isForbid;
    }
}
