namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Delete;

public class DeletedActionParameterResponse
{
    public int Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
