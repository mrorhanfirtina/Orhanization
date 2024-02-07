using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockUnsuitReason : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromResaonId { get; set; }
    public Guid? ToResaonId { get; set; }
    public virtual LogStock? LogStock { get; set; }
    public virtual UnsuitReason? FromReason { get; set; }
    public virtual UnsuitReason? ToResaon { get; set; }

    public LogStockUnsuitReason()
    {
    }

    public LogStockUnsuitReason(Guid id, Guid logStockId, Guid? fromResaonId, Guid? toResaonId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromResaonId = fromResaonId;
        ToResaonId = toResaonId;
    }
}
