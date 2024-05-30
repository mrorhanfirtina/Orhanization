namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;

public class ReceiptsPurchaseOrderResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
}
