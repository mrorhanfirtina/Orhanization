using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockReserveReason : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromReasaonId { get; set; }
    public Guid? ToReasaonId { get;set; }

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
