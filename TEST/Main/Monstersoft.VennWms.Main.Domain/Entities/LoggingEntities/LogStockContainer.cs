using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockContainer : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid? FromContainerId { get; set; }
    public Guid? ToContainerId { get; set; }
    public string? FromContainerSSCC { get; set; }
    public string? ToContainerSSCC { get; set; }
    public int? FromContainerUnitId { get; set; }
    public int? ToContainerUnitId { get; set; }
    public virtual LogStock? LogStock { get; set; }
    public virtual ContainerUnit? FromContainerUnit { get; set; }
    public virtual ContainerUnit? ToContainerUnit { get; set; }

    public LogStockContainer()
    {
    }

    public LogStockContainer(Guid id, Guid logStockId, Guid fromContainerId, Guid toContainerId, string fromContainerSSCC, string toContainerSSCC, int fromContainerUnitId, int toContainerUnitId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromContainerId = fromContainerId;
        ToContainerId = toContainerId;
        FromContainerSSCC = fromContainerSSCC;
        ToContainerSSCC = toContainerSSCC;
        FromContainerUnitId = fromContainerUnitId;
        ToContainerUnitId = toContainerUnitId;
    }
}
