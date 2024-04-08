using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.PurchaseOrderDtos;

public class CreatePurchaseOrderSubDto
{
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public CreateSupplierSubDto? Supplier { get; set; }
    public ICollection<CreatePoAttributeValueSubDto> PoAttributeValues { get; set; }
    public ICollection<CreatePoMemoSubDto> PoMemo { get; set; }
    public ICollection<CreateReceiptSubDto> Receipt { get; set; }

}

