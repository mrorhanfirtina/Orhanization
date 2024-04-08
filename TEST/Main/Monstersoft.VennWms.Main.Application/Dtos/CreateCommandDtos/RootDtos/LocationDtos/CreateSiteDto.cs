using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateSiteDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public ICollection<CreateSiteDepositorSubDto> SiteDepositors { get; set; }
}

