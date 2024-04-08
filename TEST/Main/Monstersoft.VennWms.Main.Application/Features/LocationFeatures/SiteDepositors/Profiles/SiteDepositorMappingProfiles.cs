using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Profiles;

public class SiteDepositorMappingProfiles : Profile
{
    public SiteDepositorMappingProfiles()
    {
        //CreateSiteDepositorCommand
        CreateMap<CreatedSiteDepositorResponse, SiteDepositor>().ReverseMap();

        //UpdateSiteDepositorCommand
        CreateMap<UpdatedSiteDepositorResponse, SiteDepositor>().ReverseMap();

        //DeleteSiteDepositorCommand
        CreateMap<DeletedSiteDepositorResponse, SiteDepositor>().ReverseMap();

        //GetByIdSiteDepositorQuery
        CreateMap<GetByIdSiteDepositorResponse, SiteDepositor>().ReverseMap();

        //GetListByDynamicSiteDepositorQuery
        CreateMap<SiteDepositor, GetListByDynamicSiteDepositorListItemDto>().ReverseMap();
        CreateMap<Paginate<SiteDepositor>, GetListResponse<GetListByDynamicSiteDepositorListItemDto>>().ReverseMap();

    }
}

