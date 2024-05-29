using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.UpdateDtos;

public class UpdatePurchaseOrderSubDto
{
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public UpdateSupplierSubDto? Supplier { get; set; }
    public ICollection<UpdatePoAttributeValueSubDto> PoAttributeValues { get; set; }
    public ICollection<UpdatePoMemoSubDto> PoMemo { get; set; }
    public ICollection<UpdateReceiptSubDto> Receipt { get; set; }

}

