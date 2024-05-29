using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class Unit : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual ICollection<UnitConversion>? ReferenceUnitConversions { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public Unit()
    {
        new HashSet<UnitConversion>();
    }

    public Unit(int id, string code, string description, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorCompanyId = depositorCompanyId;
    }
}
