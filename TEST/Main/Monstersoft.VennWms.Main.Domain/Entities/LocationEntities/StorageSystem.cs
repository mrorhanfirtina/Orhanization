using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class StorageSystem : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual ICollection<Location> Locations { get; set; }

    public StorageSystem()
    {
        Locations = new HashSet<Location>();
    }

    public StorageSystem(Guid id, string code, string description, Guid buildingId, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        BuildingId = buildingId;
        DepositorCompanyId = depositorCompanyId;
    }
}
