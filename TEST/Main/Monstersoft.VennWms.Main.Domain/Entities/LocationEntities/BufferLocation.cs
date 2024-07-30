using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class BufferLocation : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid BuffLocationId { get; set; }
    public bool IsBefore { get; set; }
    public virtual Location? Location { get; set; }
    public virtual Location? BuffLocation { get; set; }

    public BufferLocation()
    {
    }

    public BufferLocation(Guid locationId, Guid buffLocationId, bool isBefore) : this()
    {
        LocationId = locationId;
        BuffLocationId = buffLocationId;
        IsBefore = isBefore;
    }
}
