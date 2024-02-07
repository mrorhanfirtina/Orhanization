using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Site : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
    public virtual Building? Building { get; set; }
    public virtual ICollection<StorageSystem> StorageSystems { get; set; }

    public Site()
    {
        StorageSystems = new HashSet<StorageSystem>();
    }

    public Site(Guid id,string code, string description, Guid buildingId):this()
    {
        Id = id;
        Code = code;
        Description = description;
        BuildingId = buildingId;
    }
}
