namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Delete;

public class DeletedReceiptMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
