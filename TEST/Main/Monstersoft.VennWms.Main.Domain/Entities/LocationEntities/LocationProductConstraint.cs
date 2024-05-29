using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProductConstraint : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }
    public virtual Location? Location { get; set; }


    public LocationProductConstraint()
    {
    }

    public LocationProductConstraint(Guid id, Guid locationId, Guid itemUnitId, decimal capacity, decimal replenishmentTreshold, decimal exceedCapacityMargin) : this()
    {
        Id = id;
        LocationId = locationId;
        ItemUnitId = itemUnitId;
        Capacity = capacity;
        ReplenishmentTreshold = replenishmentTreshold;
        ExceedCapacityMargin = exceedCapacityMargin;
    }
}
