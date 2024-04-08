namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Delete;

public class DeletedUnitResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
