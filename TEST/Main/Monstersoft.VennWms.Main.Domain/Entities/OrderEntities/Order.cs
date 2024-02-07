using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

public class Order : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ActualDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid OrderTypeId { get; set; }
    public int StatusId { get; set; }
    public virtual Status? Status { get; set; }
    public virtual Customer? Customer { get; set; }
    public virtual OrderType? OrderType { get; set; }
    public virtual ICollection<OrderAttributeValue> OrderAttributeValues { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual ICollection<OrderMemo> OrderMemos { get; set; }
    public virtual ICollection<TransactionLog> TransactionLogs { get; set; }

    public Order()
    {
        OrderAttributeValues = new HashSet<OrderAttributeValue>();
        OrderItems = new HashSet<OrderItem>();
        OrderMemos = new HashSet<OrderMemo>();
        TransactionLogs = new HashSet<TransactionLog>();
    }

    public Order(Guid id, string code, Guid depositorId,Guid orderTypeId , DateTime inputDate, int statusId) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        OrderTypeId = orderTypeId;
        InputDate = inputDate;
        StatusId = statusId;
    }
}
