using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Queries.GetListByDynamic;

public class GetListByDynamicPurchaseOrderListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PurchaseOrderPoTypeResponseDto? PoType { get; set; }
    public PurchaseOrderStatusResponseDto? Status { get; set; }
    public PurchaseOrderDepositorResponseDto? Depositor { get; set; }
    public PurchaseOrderDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public PurchaseOrderSupplierResponseDto? Supplier { get; set; }
    public ICollection<PurchaseOrderPoAttributeValueResponseDto>? PoAttributeValues { get; set; }
    public ICollection<PurchaseOrderPoMemoResponseDto>? PoMemo { get; set; }
    public ICollection<PurchaseOrderReceiptResponseDto>? Receipt { get; set; }

}
