namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Delete;

public class DeletedDepositorResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
