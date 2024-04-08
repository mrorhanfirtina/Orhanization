using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class LocationCoordinate : Entity<Guid>
{
    public Guid LocationId { get; set; }
    public Guid BuildingId { get; set; }
    public decimal LocationX { get; set; }
    public decimal LocationY { get; set; }
    public decimal LocationZ { get; set; }
    public virtual Building? Building { get; set; }

    public LocationCoordinate()
    {
    }

    public LocationCoordinate(Guid id, Guid locationId, Guid buildingId, decimal locationX, decimal locationY, decimal locationZ) : this()
    {
        Id = id;
        LocationId = locationId;
        BuildingId = buildingId;
        LocationX = locationX;
        LocationY = locationY;
        LocationZ = locationZ;
    }
}
