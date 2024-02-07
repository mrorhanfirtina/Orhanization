using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Branch : Entity<Guid>
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid BuildingId { get; set; }
    public Guid CustomerId { get; set; }
    public virtual Building? Building { get; set; }
    public virtual ICollection<Shipment> Shipments { get; set; }

    public Branch()
    {
        Shipments = new HashSet<Shipment>();
    }

    public Branch(Guid id, string code, string name, Guid buildingId, Guid customerId) : this()
    {
        Id = id;
        Code = code;
        Name = name;
        BuildingId = buildingId;
        CustomerId = customerId;
    }
}
