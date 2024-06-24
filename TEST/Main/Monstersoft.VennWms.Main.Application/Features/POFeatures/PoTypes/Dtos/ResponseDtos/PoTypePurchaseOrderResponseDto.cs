namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.ResponseDtos;

public class PoTypePurchaseOrderResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public int StatusId { get; set; }
}
