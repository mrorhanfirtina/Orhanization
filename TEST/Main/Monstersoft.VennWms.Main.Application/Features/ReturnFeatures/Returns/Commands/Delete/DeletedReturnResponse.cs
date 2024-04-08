namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Delete;

public class DeletedReturnResponse
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
