namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Delete;

public class DeletedReturnTypeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
