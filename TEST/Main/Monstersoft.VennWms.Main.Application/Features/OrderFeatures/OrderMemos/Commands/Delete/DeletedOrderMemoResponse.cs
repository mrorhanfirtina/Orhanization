namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Delete;

public class DeletedOrderMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

