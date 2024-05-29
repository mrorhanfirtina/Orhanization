using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationLockReason : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public int LockReasonId { get; set; }
    public virtual LockReason? LockReason { get; set; }
    public virtual Location? Location { get; set; }

    public LocationLockReason()
    {
    }

    public LocationLockReason(Guid id, Guid locationId, int lockReasonId) : this()
    {
        Id = id;
        LocationId = locationId;
        LockReasonId = lockReasonId;
    }
}
