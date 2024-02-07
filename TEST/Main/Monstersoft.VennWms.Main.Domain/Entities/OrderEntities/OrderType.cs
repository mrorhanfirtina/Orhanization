using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class OrderType : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public Guid DepositorId { get; set; }
    public int Counter { get; set; }
    public virtual ICollection<Order> Orders { get; set; }

    public OrderType()
    {
        Orders = new HashSet<Order>();
    }

    public OrderType(Guid id, string code, string description,bool isCodeGenerate , string format, Guid depositorId, int counter) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        IsCodeGenerate = isCodeGenerate;
        Format = format;
        DepositorId = depositorId;
        Counter = counter;
    }
}
