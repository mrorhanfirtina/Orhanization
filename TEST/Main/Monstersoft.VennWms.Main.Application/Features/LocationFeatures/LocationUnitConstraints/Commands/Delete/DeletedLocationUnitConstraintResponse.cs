namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Commands.Delete;

public class DeletedLocationUnitConstraintResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}

