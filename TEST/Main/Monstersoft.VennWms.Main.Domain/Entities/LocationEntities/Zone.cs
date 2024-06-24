using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

public class Zone : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual Building? Building { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public Zone()
    {

    }

    public Zone(string code, string description, Guid buildingId, Guid depositorCompanyId) : this()
    {
        Code = code;
        Description = description;
        BuildingId = buildingId;
        DepositorCompanyId = depositorCompanyId;
    }
}
