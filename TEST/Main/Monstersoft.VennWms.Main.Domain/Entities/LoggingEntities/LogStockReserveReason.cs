using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockReserveReason : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromReasaonId { get; set; }
    public Guid? ToReasaonId { get;set; }
    public virtual LogStock? LogStock { get; set; }
    public virtual ReserveReason? FromReason { get; set; }
    public virtual ReserveReason? ToReason { get; set; }

    public LogStockReserveReason()
    {
    }

    public LogStockReserveReason(Guid id, Guid logStockId, Guid? fromReasaonId, Guid? toReasaonId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromReasaonId = fromReasaonId;
        ToReasaonId = toReasaonId;
    }
}
