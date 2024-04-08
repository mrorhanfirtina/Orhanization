namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Delete;

public class DeletedBranchResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
