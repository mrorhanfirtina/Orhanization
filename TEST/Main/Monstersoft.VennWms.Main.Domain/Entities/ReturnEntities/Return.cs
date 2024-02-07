using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

public class Return : Entity<Guid>
{
    public string Code { get; set; }
    public Guid CustomerId { get; set; }
    public int StatusId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid ReturnTypeId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public virtual Customer? Customer { get; set; }
    public virtual ReturnType? ReturnType { get; set; }
    public virtual ICollection<TransactionLog> TransactionLogs { get; set; }
    public virtual ICollection<ReturnAttributeValue> ReturnAttributeValues { get; set; }
    public virtual ICollection<ReturnItem> ReturnItems { get; set; }
    public virtual ICollection<ReturnMemo> ReturnMemos { get; set; }

    public Return()
    {
        TransactionLogs = new HashSet<TransactionLog>();
        ReturnAttributeValues = new HashSet<ReturnAttributeValue>();
        ReturnItems = new HashSet<ReturnItem>();
        ReturnMemos = new HashSet<ReturnMemo>();
    }

    public Return(Guid id, string code, DateTime inputDate, Guid customerId, Guid returnTypeId, int statusId, Guid depositorId) : this()
    {
        Id = id;
        Code = code;
        InputDate = inputDate;
        CustomerId = customerId;
        StatusId = statusId;
        ReturnTypeId = returnTypeId;
        DepositorId = depositorId;
    }
}
