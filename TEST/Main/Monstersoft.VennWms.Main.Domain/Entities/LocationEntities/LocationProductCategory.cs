using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProductCategory : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int CategoryId { get; set; }
    public virtual ProductCategoryList? Category { get; set; }
    public virtual Location? Location { get; set; }
    public LocationProductCategory()
    {
    }

    public LocationProductCategory(Guid id, Guid locationId, int categoryId) : this()
    {
        Id = id;
        LocationId = locationId;
        CategoryId = categoryId;
    }
}
