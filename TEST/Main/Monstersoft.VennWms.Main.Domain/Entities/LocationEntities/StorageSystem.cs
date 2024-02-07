using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class StorageSystem : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid SiteId { get; set; }
    public virtual Site? Site { get; set; }
    public virtual ICollection<Location> Locations { get; set; }

    public StorageSystem()
    {
        Locations = new HashSet<Location>();
    }

    public StorageSystem(Guid id, string code, string description, Guid siteId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        SiteId = siteId;
    }
}
