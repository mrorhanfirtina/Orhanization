using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;

public class CreateReceiptDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ReceiveDate { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public int StatusId { get; set; }
    public CreatePurchaseOrderSubDto? PurchaseOrder { get; set; }
    public ICollection<CreateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<CreateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<CreateReceiptMemoSubDto> ReceiptMemos { get; set; }
}

