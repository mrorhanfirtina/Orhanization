using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class Depositor : Entity<Guid>
{
    public string Code { get; set; }
    public Guid BuildingId { get; set; }
    public Guid DepositorCompanyId { get; set; }

    public virtual Building? Building { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }

    public Depositor()
    {

    }

    public Depositor(Guid id, string code, Guid buildingId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        BuildingId = buildingId;
        DepositorCompanyId = depositorCompanyId;
    }
}
