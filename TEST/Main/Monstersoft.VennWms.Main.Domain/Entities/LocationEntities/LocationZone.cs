using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationZone : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid ZoneId { get; set; }
    public virtual Zone? Zone { get; set; }
    public virtual Location? Location { get; set; }
    public LocationZone()
    {
    }

    public LocationZone(Guid locationId, Guid zoneId) : this()
    {
        LocationId = locationId;
        ZoneId = zoneId;
    }
}
