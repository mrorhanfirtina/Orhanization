namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Delete;

public class DeletedCompanyResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
