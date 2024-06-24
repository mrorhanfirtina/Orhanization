namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Delete;

public class DeletedPoTypeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
