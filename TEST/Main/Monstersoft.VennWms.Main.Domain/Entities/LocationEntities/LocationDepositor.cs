using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationDepositor : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
    public virtual Depositor? Depositor { get; set; }

    public LocationDepositor()
    {
    }

    public LocationDepositor(Guid id, Guid locationId, Guid depositorId, bool isForbid) : this()
    {
        Id = id;
        LocationId = locationId;
        DepositorId = depositorId;
        IsForbid = isForbid;
    }
}
