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

public class UnsuitReason : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsBlocked { get; set; }
    public virtual ICollection<LogStockUnsuitReason> LogStockUnsuitReasons { get; set; }
    public virtual ICollection<StockUnsuitReason> StockUnsuitReasons { get; set; }

    public UnsuitReason()
    {
        LogStockUnsuitReasons = new HashSet<LogStockUnsuitReason>();
        StockUnsuitReasons = new HashSet<StockUnsuitReason>();
    }

    public UnsuitReason(Guid id,string code, string description, Guid depositorId, bool isBlocked) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorId = depositorId;
        IsBlocked = isBlocked;
    }
}
