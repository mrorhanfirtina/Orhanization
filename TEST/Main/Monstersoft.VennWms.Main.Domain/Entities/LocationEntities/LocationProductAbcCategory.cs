using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProductAbcCategory : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int AbcCategoryId { get; set; }
    public virtual AbcCategoryList? AbcCategory { get; set; }
    public virtual Location? Location { get; set; }

    public LocationProductAbcCategory()
    {
    }

    public LocationProductAbcCategory(Guid id, Guid locationId, int abcCategoryId) : this()
    {
        Id = id;
        LocationId = locationId;
        AbcCategoryId = abcCategoryId;
    }
}
