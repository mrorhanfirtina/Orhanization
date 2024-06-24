namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Delete;

public class DeletedDistributorResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

