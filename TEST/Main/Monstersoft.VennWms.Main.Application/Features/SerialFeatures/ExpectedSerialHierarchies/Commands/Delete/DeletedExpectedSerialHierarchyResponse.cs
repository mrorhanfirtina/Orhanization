namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Delete;

public class DeletedExpectedSerialHierarchyResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
