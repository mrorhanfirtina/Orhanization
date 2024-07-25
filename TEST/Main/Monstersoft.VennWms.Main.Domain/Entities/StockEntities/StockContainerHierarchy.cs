using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

public class StockContainerHierarchy : Entity<Guid>
{
    public Guid ParentContainerId { get; set; }
    public Guid ChildContainerId { get; set; }
    public virtual StockContainer? ParentContainer { get; set; }
    public virtual StockContainer? ChildContainer { get; set; }

    public StockContainerHierarchy()
    {
    }

    public StockContainerHierarchy(Guid parentContainerId, Guid childContainerId) : this()
    {
        ParentContainerId = parentContainerId;
        ChildContainerId = childContainerId;
    }

}
