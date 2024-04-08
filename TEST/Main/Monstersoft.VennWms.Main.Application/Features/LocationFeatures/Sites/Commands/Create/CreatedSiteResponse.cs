namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;

public class CreatedSiteResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }

}

