using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetListByDynamic;

public class GetListByDynamicSiteListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public SiteDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<SiteSiteDepositorResponseDto>? SiteDepositors { get; set; }
    public ICollection<SiteBuildingResponseDto>? Buildings { get; set; }

}

