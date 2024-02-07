using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockContainer : Entity<Guid>
{
    public string Sscc { get; set; }
    public Guid ContainerUnitId { get; set; }
    public virtual ContainerUnit? ContainerUnit { get; set; }
    public virtual ICollection<Stock> Stocks { get; set; }

    public StockContainer()
    {
        Stocks = new HashSet<Stock>();
    }

    public StockContainer(Guid id, string sscc, Guid containerUnitId) : this()
    {
        Id = id;
        Sscc = sscc;
        ContainerUnitId = containerUnitId;
    }
}
