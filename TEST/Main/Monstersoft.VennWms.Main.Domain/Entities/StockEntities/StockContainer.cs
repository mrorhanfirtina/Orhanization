using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockContainer : Entity<Guid>
{
    public string Sscc { get; set; }
    public int ContainerUnitId { get; set; }
    public virtual ContainerUnit? ContainerUnit { get; set; }
    public virtual ICollection<Stock>? Stocks { get; set; }

    public StockContainer()
    {

    }

    public StockContainer(Guid id, string sscc, int containerUnitId) : this()
    {
        Id = id;
        Sscc = sscc;
        ContainerUnitId = containerUnitId;
    }
}
