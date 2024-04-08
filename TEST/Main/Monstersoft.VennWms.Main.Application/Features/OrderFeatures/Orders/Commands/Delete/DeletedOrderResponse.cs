namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Delete;

public class DeletedOrderResponse
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
