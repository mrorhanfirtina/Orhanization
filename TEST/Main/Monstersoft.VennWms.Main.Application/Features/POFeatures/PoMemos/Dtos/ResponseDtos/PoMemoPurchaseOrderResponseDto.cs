namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.ResponseDtos;

public class PoMemoPurchaseOrderResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
}
