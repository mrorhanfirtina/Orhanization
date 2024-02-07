using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Supplier : Entity<Guid>
{
    public string Code { get; set; }
    public Guid BuildingId { get; set; }
    public Guid CompanyId { get; set; }
    public Guid DepositorId { get; set; }
    public virtual Building? Building { get; set; }
    public virtual Company? Company { get; set; }
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }

    public Supplier()
    {
        PurchaseOrders = new HashSet<PurchaseOrder>();
    }

    public Supplier(Guid id, string code, Guid buildingId, Guid companyId, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        BuildingId = buildingId;
        CompanyId = companyId;
        DepositorId = depositorId;
    }
}
