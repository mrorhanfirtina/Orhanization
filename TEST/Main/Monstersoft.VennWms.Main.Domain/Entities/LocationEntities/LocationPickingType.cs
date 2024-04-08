using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationPickingType : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int PickingTypeId { get; set; }
    public virtual PickingType? PickingType { get; set; }

    public LocationPickingType()
    {
    }

    public LocationPickingType(Guid id, Guid locationId, int pickingTypeId) : this()
    {
        Id = id;
        LocationId = locationId;
        PickingTypeId = pickingTypeId;
    }
}
