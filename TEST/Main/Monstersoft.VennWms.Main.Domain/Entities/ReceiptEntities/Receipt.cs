using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

public class Receipt : Entity<Guid>
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public Guid? PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public int StatusId { get; set; }
    public virtual ICollection<ReceiptAttributeValue> ReceiptAttributeValues { get; set; }
    public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    public virtual ICollection<ReceiptMemo> ReceiptMemos { get; set; }
    public virtual Depositor Depositor { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual Status Status { get; set; }

    public Receipt()
    {
        ReceiptAttributeValues = new HashSet<ReceiptAttributeValue>();
        ReceiptItems = new HashSet<ReceiptItem>();
        ReceiptMemos = new HashSet<ReceiptMemo>();
    }

    public Receipt(Guid id, string code, Guid depositorId, Guid depositorCompanyId, DateTime inputDate, Guid purchaseOrderId, Guid receiptTypeId, int statusId) : this()
    {
        Id = id;
        Code = code;
        DepositorId = depositorId;
        InputDate = inputDate;
        PurchaseOrderId = purchaseOrderId;
        ReceiptTypeId = receiptTypeId;
        StatusId = statusId;
        DepositorCompanyId = depositorCompanyId;
    }
}
