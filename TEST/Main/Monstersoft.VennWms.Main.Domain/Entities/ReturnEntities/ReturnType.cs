using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnType : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsCodeGenerate { get; set; }
    public int Counter { get; set; }
    public string Format { get; set; }
    public virtual ICollection<Return>? Returns { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }

    public ReturnType()
    {
        Returns = new HashSet<Return>();
    }

    public ReturnType(Guid id, string code, string description, Guid depositorCompanyId, bool isCodeGenerate, int counter, string format) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorCompanyId = depositorCompanyId;
        IsCodeGenerate = isCodeGenerate;
        Counter = counter;
        Format = format;
    }
}
