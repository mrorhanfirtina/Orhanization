using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Profiles;

public class ReturnTypesMappingProfiles : Profile
{
    public ReturnTypesMappingProfiles()
    {

        //CreateReturnTypeCommand
        CreateMap<CreatedReturnTypeResponse, ReturnType>().ReverseMap();

        //UpdateReturnTypeCommand
        CreateMap<UpdatedReturnTypeResponse, ReturnType>().ReverseMap();

        //DeleteReturnTypeCommand
        CreateMap<DeletedReturnTypeResponse, ReturnType>().ReverseMap();

        //GetByCodeReturnTypeQuery
        CreateMap<GetByCodeReturnTypeResponse, ReturnType>().ReverseMap();

        //GetByIdReturnTypeQuery
        CreateMap<GetByIdReturnTypeResponse, ReturnType>().ReverseMap();

        //GetListReturnTypeQuery
        CreateMap<GetListReturnTypeListItemDto, ReturnType>().ReverseMap();
        CreateMap<Paginate<ReturnType>, GetListResponse<GetListReturnTypeListItemDto>>().ReverseMap();

        //GetListByDynamicReturnTypeQuery
        CreateMap<GetListByDynamicReturnTypeListItemDto, ReturnType>().ReverseMap();
        CreateMap<Paginate<ReturnType>, GetListResponse<GetListByDynamicReturnTypeListItemDto>>().ReverseMap();

    }
}
