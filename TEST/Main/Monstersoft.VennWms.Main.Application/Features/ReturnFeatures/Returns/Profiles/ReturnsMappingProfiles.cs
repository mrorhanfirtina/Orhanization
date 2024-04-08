using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Profiles;

public class ReturnsMappingProfiles : Profile
{
    public ReturnsMappingProfiles()
    {

        //CreateReturnCommand
        CreateMap<CreatedReturnResponse, Return>().ReverseMap();

        //UpdateReturnCommand
        CreateMap<UpdatedReturnResponse, Return>().ReverseMap();

        //DeleteReturnCommand
        CreateMap<DeletedReturnResponse, Return>().ReverseMap();

        //GetByCodeReturnQuery
        CreateMap<GetByCodeReturnResponse, Return>().ReverseMap();

        //GetByIdReturnQuery
        CreateMap<GetByIdReturnResponse, Return>().ReverseMap();

        //GetListReturnQuery
        CreateMap<GetListReturnListItemDto, Return>().ReverseMap();
        CreateMap<Paginate<Return>, GetListResponse<GetListReturnListItemDto>>().ReverseMap();

        //GetListByDynamicReturnQuery
        CreateMap<GetListByDynamicReturnListItemDto, Return>().ReverseMap();
        CreateMap<Paginate<Return>, GetListResponse<GetListByDynamicReturnListItemDto>>().ReverseMap();

    }
}
