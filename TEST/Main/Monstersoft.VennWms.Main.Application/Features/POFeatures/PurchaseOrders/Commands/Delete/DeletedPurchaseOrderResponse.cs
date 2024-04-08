namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Delete;

public class DeletedPurchaseOrderResponse
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
