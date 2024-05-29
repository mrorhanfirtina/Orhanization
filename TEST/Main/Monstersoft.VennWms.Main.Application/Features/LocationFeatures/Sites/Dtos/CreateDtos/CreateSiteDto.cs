using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.CreateDtos;

public class CreateSiteDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public ICollection<CreateSiteDepositorSubDto> SiteDepositors { get; set; }
}

