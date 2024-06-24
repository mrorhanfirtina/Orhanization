namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Delete;

public class DeletedLocationDepositorResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

