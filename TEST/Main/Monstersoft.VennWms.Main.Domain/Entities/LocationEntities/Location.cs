using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Location : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public virtual StorageSystem? StorageSystem { get; set; }
    public virtual ICollection<LogStock> LogStocks { get; set; }
    public virtual ICollection<Stock> Stocks { get; set; }

    public Location()
    {
        LogStocks = new HashSet<LogStock>();
        Stocks = new HashSet<Stock>();
    }

    public Location(Guid id,string code, string description, Guid storageSystemId): this()
    {
        Id = id;
        Code = code;
        Description = description;
        StorageSystemId = storageSystemId;
    }
}
