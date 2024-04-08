namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Delete;

public class DeletedUnsuitReasonResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
