namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Delete;

public class DeletedOrderItemResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
