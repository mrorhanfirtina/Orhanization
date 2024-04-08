namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Delete;

public class DeletedReceiptItemResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
