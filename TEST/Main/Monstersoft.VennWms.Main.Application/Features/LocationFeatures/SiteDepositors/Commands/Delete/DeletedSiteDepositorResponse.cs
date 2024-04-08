namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Delete;

public class DeletedSiteDepositorResponse
{
    public Guid Id { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}

