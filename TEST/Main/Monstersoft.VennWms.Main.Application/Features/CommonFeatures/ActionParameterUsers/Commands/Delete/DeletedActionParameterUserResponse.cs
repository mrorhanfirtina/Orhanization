namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Delete;

public class DeletedActionParameterUserResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
