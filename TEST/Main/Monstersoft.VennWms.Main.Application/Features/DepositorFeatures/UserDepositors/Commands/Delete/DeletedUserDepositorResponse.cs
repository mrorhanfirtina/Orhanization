namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Delete;

public class DeletedUserDepositorResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

