using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Profiles;

public class ReturnAttributesMappingProfiles : Profile
{
    public ReturnAttributesMappingProfiles()
    {

        //CreateReturnAttributeCommand
        CreateMap<CreatedReturnAttributeResponse, ReturnAttribute>().ReverseMap();

        //UpdateReturnAttributeCommand
        CreateMap<UpdatedReturnAttributeResponse, ReturnAttribute>().ReverseMap();

        //DeleteReturnAttributeCommand
        CreateMap<DeletedReturnAttributeResponse, ReturnAttribute>().ReverseMap();

        //GetByCodeReturnAttributeQuery
        CreateMap<GetByCodeReturnAttributeResponse, ReturnAttribute>().ReverseMap();

        //GetByIdReturnAttributeQuery
        CreateMap<GetByIdReturnAttributeResponse, ReturnAttribute>().ReverseMap();

        //GetListReturnAttributeQuery
        CreateMap<GetListReturnAttributeListItemDto, ReturnAttribute>().ReverseMap();
        CreateMap<Paginate<ReturnAttribute>, GetListResponse<GetListReturnAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicReturnAttributeQuery
        CreateMap<GetListByDynamicReturnAttributeListItemDto, ReturnAttribute>().ReverseMap();
        CreateMap<Paginate<ReturnAttribute>, GetListResponse<GetListByDynamicReturnAttributeListItemDto>>().ReverseMap();

    }
}
