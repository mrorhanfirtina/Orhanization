using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationUnitConstraint : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public virtual Unit? Unit { get; set; }

    public LocationUnitConstraint()
    {
    }

    public LocationUnitConstraint(Guid id, Guid locationId, int unitId, decimal capacity) : this()
    {
        Id = id;
        LocationId = locationId;
        UnitId = unitId;
        Capacity = capacity;
    }
}
