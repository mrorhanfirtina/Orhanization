using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Profiles;

public class SitesMappingProfiles : Profile
{
    public SitesMappingProfiles()
    {

        //CreateSiteCommand
        CreateMap<CreatedSiteResponse, Site>().ReverseMap();

        //UpdateSiteCommand
        CreateMap<UpdatedSiteResponse, Site>().ReverseMap();

        //DeleteSiteCommand
        CreateMap<DeletedSiteResponse, Site>().ReverseMap();

        //GetByCodeSiteQuery
        CreateMap<GetByCodeSiteResponse, Site>().ReverseMap();

        //GetByIdSiteQuery
        CreateMap<GetByIdSiteResponse, Site>().ReverseMap();

        //GetListSiteQuery
        CreateMap<GetListSiteListItemDto, Site>().ReverseMap();
        CreateMap<Paginate<Site>, GetListResponse<GetListSiteListItemDto>>().ReverseMap();

        //GetListByDynamicSiteQuery
        CreateMap<GetListByDynamicSiteListItemDto, Site>().ReverseMap();
        CreateMap<Paginate<Site>, GetListResponse<GetListByDynamicSiteListItemDto>>().ReverseMap();

    }
}

