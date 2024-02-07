using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

public class TransactionType : Entity<int>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public bool IsLogging { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<LogStock> LogStocks { get; set; }
    public virtual ICollection<WorkTask> WorkTasks { get; set; }


    public TransactionType()
    {
        LogStocks = new HashSet<LogStock>();
        WorkTasks = new HashSet<WorkTask>();
    }

    public TransactionType(int id, string code, string description, string format, int counter, bool isLogging,Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        Format = format;
        Counter = counter;
        IsLogging = isLogging;
        DepositorId = depositorId;
    }
}
