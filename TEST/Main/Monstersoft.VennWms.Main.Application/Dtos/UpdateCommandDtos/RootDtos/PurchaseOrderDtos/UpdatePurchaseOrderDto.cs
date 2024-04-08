using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.PurchaseOrderDtos;

public class UpdatePurchaseOrderDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
    public UpdateSupplierSubDto? Supplier { get; set; }
    public ICollection<UpdatePoAttributeValueSubDto> PoAttributeValues { get; set; }
    public ICollection<UpdatePoMemoSubDto> PoMemo { get; set; }
    public ICollection<UpdateReceiptSubDto> Receipt { get; set; }
}

