using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.UpdateDtos;

public class UpdateSiteDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public ICollection<UpdateSiteDepositorSubDto> SiteDepositors { get; set; }
}

