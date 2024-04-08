namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Delete;

public class DeletedReturnMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
