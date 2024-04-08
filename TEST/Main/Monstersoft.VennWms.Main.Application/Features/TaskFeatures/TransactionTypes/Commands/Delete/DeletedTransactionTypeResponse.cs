namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Delete;

public class DeletedTransactionTypeResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

