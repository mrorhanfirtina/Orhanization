using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockUnsuitReason : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromReasonId { get; set; }
    public Guid? ToReasonId { get; set; }

    public LogStockUnsuitReason()
    {
    }

    public LogStockUnsuitReason(Guid id, Guid logStockId, Guid? fromReasonId, Guid? toReasonId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromReasonId = fromReasonId;
        ToReasonId = toReasonId;
    }
}
