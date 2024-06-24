using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockReserveReason : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get;set; }
    public virtual LogStock? LogStock { get; set; }
    public virtual ReserveReason? FromReason { get; set; }
    public virtual ReserveReason? ToReason { get; set; }

    public LogStockReserveReason()
    {
    }

    public LogStockReserveReason(Guid id, Guid logStockId, Guid? fromReasonId, Guid? toReasonId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromReasonId = fromReasonId;
        ToReasonId = toReasonId;
    }
}
