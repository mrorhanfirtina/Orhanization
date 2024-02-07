using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class ReserveReason : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsBlocked { get; set; }
    public virtual ICollection<LogStockReserveReason> LogStockReserveReasons { get; set; }
    public virtual ICollection<StockReserveReason> StockReserveReasons { get; set; }

    public ReserveReason()
    {
        LogStockReserveReasons = new HashSet<LogStockReserveReason>();
        StockReserveReasons = new HashSet<StockReserveReason>();
    }

    public ReserveReason(Guid id, string code, string description, Guid depositorId, bool isBlocked) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorId = depositorId;
        IsBlocked = isBlocked;
    }
}
