namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Delete;

public class DeletedSiteResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

