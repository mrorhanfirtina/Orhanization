namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Delete;

public class DeletedOrderItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

