using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Profiles;

public class ReturnItemsMappingProfiles : Profile
{
    public ReturnItemsMappingProfiles()
    {

        //CreateReturnItemCommand
        CreateMap<CreatedReturnItemResponse, ReturnItem>().ReverseMap();

        //UpdateReturnItemCommand
        CreateMap<UpdatedReturnItemResponse, ReturnItem>().ReverseMap();

        //DeleteReturnItemCommand
        CreateMap<DeletedReturnItemResponse, ReturnItem>().ReverseMap();

        //GetByIdReturnItemQuery
        CreateMap<GetByIdReturnItemResponse, ReturnItem>().ReverseMap();

        //GetListByDynamicReturnItemQuery
        CreateMap<GetListByDynamicReturnItemListItemDto, ReturnItem>().ReverseMap();
        CreateMap<Paginate<ReturnItem>, GetListResponse<GetListByDynamicReturnItemListItemDto>>().ReverseMap();

    }
}
