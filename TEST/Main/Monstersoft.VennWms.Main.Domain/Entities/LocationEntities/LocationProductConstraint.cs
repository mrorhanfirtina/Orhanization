using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationProductConstraint : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public decimal Capacity { get; set; }
    public decimal ReplenishmentTreshold { get; set; }
    public decimal ExceedCapacityMargin { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Unit? Unit { get; set; }



    public LocationProductConstraint()
    {
    }

    public LocationProductConstraint(Guid id, Guid locationId, Guid productId, int unitId, decimal capacity, decimal replenishmentTreshold, decimal exceedCapacityMargin) : this()
    {
        Id = id;
        LocationId = locationId;
        ProductId = productId;
        UnitId = unitId;
        Capacity = capacity;
        ReplenishmentTreshold = replenishmentTreshold;
        ExceedCapacityMargin = exceedCapacityMargin;
    }
}
