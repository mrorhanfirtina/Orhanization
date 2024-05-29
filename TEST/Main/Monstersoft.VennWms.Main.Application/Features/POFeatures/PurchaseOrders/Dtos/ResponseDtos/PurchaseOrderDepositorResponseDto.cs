namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;

public class PurchaseOrderDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public PurchaseOrderCompanyResponseDto? Company { get; set; }
}
