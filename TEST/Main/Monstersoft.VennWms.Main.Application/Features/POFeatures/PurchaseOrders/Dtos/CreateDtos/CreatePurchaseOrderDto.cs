using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.CreateDtos;

public class CreatePurchaseOrderDto
{
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
    public CreateSupplierSubDto? Supplier { get; set; }
    public ICollection<CreatePoAttributeValueSubDto>? PoAttributeValues { get; set; }
    public ICollection<CreatePoMemoSubDto>? PoMemo { get; set; }
    public ICollection<CreateReceiptSubDto>? Receipt { get; set; }
}

