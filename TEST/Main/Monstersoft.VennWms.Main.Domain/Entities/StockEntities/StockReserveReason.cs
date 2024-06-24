using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockReserveReason : Entity<Guid>
{
    public Guid StockId { get; set; }
    public Guid ReserveReasonId { get; set; }
    public virtual ReserveReason? ReserveReason { get; set; }
    public virtual Stock? Stock { get; set; }

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
