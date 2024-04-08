using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetListByDynamic;

public class GetListByDynamicReceiptListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ReceiveDate { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PurchaseOrder PurchaseOrder { get; set; }
    public ReceiptType ReceiptType { get; set; }
    public ICollection<ReceiptAttributeValue> ReceiptAttributeValues { get; set; }
    public ICollection<ReceiptItem> ReceiptItems { get; set; }
    public ICollection<ReceiptMemo> ReceiptMemos { get; set; }

}
