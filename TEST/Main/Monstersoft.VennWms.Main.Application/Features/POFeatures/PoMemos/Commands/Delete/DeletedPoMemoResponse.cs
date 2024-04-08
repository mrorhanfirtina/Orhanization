namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Delete;

public class DeletedPoMemoResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
