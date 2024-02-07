using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockUnsuitReason : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid UnsuitReasonId { get; set; }
    public virtual Stock? Stock { get; set; }
    public virtual UnsuitReason? UnsuitReason { get; set; }

    public StockUnsuitReason()
    {
    }

    public StockUnsuitReason(Guid id, Guid stockId, Guid unsuitReasonId) : this()
    {
        Id = id;
        StockId = stockId;
        UnsuitReasonId = unsuitReasonId;
    }
}
