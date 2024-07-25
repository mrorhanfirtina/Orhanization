using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Queries.GetList;

public class GetListReceiptListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public DateTime? ReceiveDate { get; set; }
    public Guid? PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public Guid SupplierId { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReceiptsReceiptTypeResponseDto? ReceiptType { get; set; }
    public ReceiptsPurchaseOrderResponseDto? PurchaseOrder { get; set; }
    public ReceiptsDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ReceiptsStatusResponseDto? Status { get; set; }
    public ReceiptsSupplierResponseDto? Supplier { get; set; }
    public ICollection<ReceiptsReceiptAttributeValueResponseDto>? ReceiptAttributeValues { get; set; }
    public ICollection<ReceiptsReceiptMemoResponseDto>? ReceiptMemos { get; set; }
    public ReceiptsDepositorResponseDto? Depositor { get; set; }
}
