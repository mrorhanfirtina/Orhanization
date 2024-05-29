using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationStockAttribute : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
    public virtual StockAttribute? StockAttribute { get; set; }
    public virtual Location? Location { get; set; }

    public LocationStockAttribute()
    {
    }

    public LocationStockAttribute(Guid locationId, Guid stockAttributeId, bool isForbid) : this()
    {
        LocationId = locationId;
        StockAttributeId = stockAttributeId;
        IsForbid = isForbid;
    }
}
