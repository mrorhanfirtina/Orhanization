using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockReserveReason : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual ReserveReason? ReserveReason { get; set; }

    public StockReserveReason()
    {
    }

    public StockReserveReason(Guid id, Guid stockId, Guid reserveReasonId) : this()
    {
        Id = id;
        StockId = stockId;
        ReserveReasonId = reserveReasonId;
    }
}
