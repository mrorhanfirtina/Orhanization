using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderAttribute : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public bool IsItemAttribte { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual AttributeInputType AttributeInputType { get; set; }
    public OrderAttribute()
    {
    }

    public OrderAttribute(Guid id,string code, string description, int attributeInputTypeId, bool isNecessary, bool isItemAttribte, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AttributeInputTypeId = attributeInputTypeId;
        IsNecessary = isNecessary;
        IsItemAttribte = isItemAttribte;
        DepositorCompanyId = depositorCompanyId;
    }
}
