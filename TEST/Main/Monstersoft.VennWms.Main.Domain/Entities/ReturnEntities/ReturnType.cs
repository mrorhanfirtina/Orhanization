using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class ReturnType : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsCodeGenerate { get; set; }
    public int Counter { get; set; }
    public string Format { get; set; }
    public virtual ICollection<Return> Returns { get; set; }

    public ReturnType()
    {
        Returns = new HashSet<Return>();
    }

    public ReturnType(Guid id, string code, string description, Guid depositorId, bool ısCodeGenerate, int counter, string format) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        DepositorId = depositorId;
        IsCodeGenerate = ısCodeGenerate;
        Counter = counter;
        Format = format;
    }
}
