namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Delete;

public class DeletedOrderPriorityResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}


