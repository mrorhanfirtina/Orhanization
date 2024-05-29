using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Queries.GetList;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Profiles;

public class PriorityListMappingProfiles : Profile
{
    public PriorityListMappingProfiles()
    {
        //CreatePriorityListCommand
        CreateMap<CreatedPriorityListResponse, PriorityList>().ReverseMap();

        //UpdatePriorityListCommand
        CreateMap<UpdatedPriorityListResponse, PriorityList>().ReverseMap();

        //DeletePriorityListCommand
        CreateMap<DeletedPriorityListResponse, PriorityList>().ReverseMap();

        //GetByIdPriorityListQuery
        CreateMap<GetByIdPriorityListResponse, PriorityList>().ReverseMap();

        //GetListByDynamicPriorityListQuery
        CreateMap<PriorityList, GetListByDynamicPriorityListListItemDto>().ReverseMap();
        CreateMap<Paginate<PriorityList>, GetListResponse<GetListByDynamicPriorityListListItemDto>>().ReverseMap();

        //GetByCodePriorityListQuery
        CreateMap<GetByCodePriorityListResponse, PriorityList>().ReverseMap();

        //GetListPriorityListQuery
        CreateMap<PriorityList, GetListPriorityListListItemDto>().ReverseMap();
        CreateMap<Paginate<PriorityList>, GetListResponse<GetListPriorityListListItemDto>>().ReverseMap();
    }
}



