using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderType : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public int Counter { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public OrderType()
    {
        Orders = new HashSet<Order>();
    }

    public OrderType(Guid id, string code, string description,bool isCodeGenerate , string format, Guid depositorCompanyId, int counter) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        IsCodeGenerate = isCodeGenerate;
        Format = format;
        DepositorCompanyId = depositorCompanyId;
        Counter = counter;
    }
}
