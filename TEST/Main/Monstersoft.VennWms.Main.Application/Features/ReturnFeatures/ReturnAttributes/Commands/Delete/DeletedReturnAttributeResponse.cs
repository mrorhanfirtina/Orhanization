namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Delete;

public class DeletedReturnAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
