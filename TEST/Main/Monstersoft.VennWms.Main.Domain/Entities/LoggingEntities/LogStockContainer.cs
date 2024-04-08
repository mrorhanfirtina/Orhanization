using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

public class LogStockContainer : Entity<Guid>
{
    public Guid LogStockId { get; set; }
    public Guid FromContainerId { get; set; }
    public Guid ToContainerId { get; set; }
    public string FromContainerSSCC { get; set; }
    public string ToContainerSSCC { get; set; }
    public int FromContainerTypeId { get; set; }
    public int ToContainerTypeId { get; set; }

    public LogStockContainer()
    {
    }

    public LogStockContainer(Guid id, Guid logStockId, Guid fromContainerId, Guid toContainerId, string fromContainerSSCC, string toContainerSSCC, int fromContainerTypeId, int toContainerTypeId) : this()
    {
        Id = id;
        LogStockId = logStockId;
        FromContainerId = fromContainerId;
        ToContainerId = toContainerId;
        FromContainerSSCC = fromContainerSSCC;
        ToContainerSSCC = toContainerSSCC;
        FromContainerTypeId = fromContainerTypeId;
        ToContainerTypeId = toContainerTypeId;
    }
}
