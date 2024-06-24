namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Commands.Delete;

public class DeletedLocationProductConstraintResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

