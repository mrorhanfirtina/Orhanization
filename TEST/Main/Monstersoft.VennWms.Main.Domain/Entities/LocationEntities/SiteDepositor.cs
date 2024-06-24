using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class SiteDepositor : Entity<Guid>
{
    public Guid SiteId { get; set; }
    public Guid DepositorId { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual Site? Site { get; set; }
    public SiteDepositor()
    {
    }

    public SiteDepositor(Guid id, Guid siteId, Guid depositorId) : this()
    {
        Id = id;
        SiteId = siteId;
        DepositorId = depositorId;
    }

}

