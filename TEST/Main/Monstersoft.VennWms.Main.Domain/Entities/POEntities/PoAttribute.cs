using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.POEntities;

public class PoAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public virtual AttributeInputType AttributeInputType { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public PoAttribute()
    {
    }

    public PoAttribute(Guid id,string code, string description, int attributeInputTypeId, Guid depositorCompanyId, bool isNecessary) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        DepositorCompanyId = depositorCompanyId;
        IsNecessary = isNecessary;
    }
}
