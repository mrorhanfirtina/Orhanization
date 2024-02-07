using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class Receipt : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public int StatusId { get; set; }
    public virtual PurchaseOrder? PurchaseOrder { get; set; }
    public virtual ReceiptType? ReceiptType { get; set; }
    public virtual ICollection<TransactionLog> TransactionLogs { get; set; }
    public virtual ICollection<ReceiptAttributeValue> ReceiptAttributeValues { get; set; }
    public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    public virtual ICollection<ReceiptItmStockAttrValue> ReceiptItmStockAttrValues { get; set; }
    public virtual ICollection<ReceiptMemo> ReceiptMemos { get; set; }

    public Receipt()
    {
        TransactionLogs = new HashSet<TransactionLog>();
        ReceiptAttributeValues = new HashSet<ReceiptAttributeValue>();
        ReceiptItems = new HashSet<ReceiptItem>();
        ReceiptItmStockAttrValues = new HashSet<ReceiptItmStockAttrValue>();
        ReceiptMemos = new HashSet<ReceiptMemo>();
    }

    public Receipt(Guid id, string code, Guid depositorId, DateTime inputDate, Guid purchaseOrderId, Guid receiptTypeId, int statusId) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        InputDate = inputDate;
        PurchaseOrderId = purchaseOrderId;
        ReceiptTypeId = receiptTypeId;
        StatusId = statusId;
    }
}
