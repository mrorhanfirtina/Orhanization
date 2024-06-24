using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Profiles;

public class ItemPackTypesMappingProfiles : Profile
{
    public ItemPackTypesMappingProfiles()
    {

        //CreateItemPackTypeCommand
        CreateMap<CreatedItemPackTypeResponse, ItemPackType>().ReverseMap();

        //UpdateItemPackTypeCommand
        CreateMap<UpdatedItemPackTypeResponse, ItemPackType>().ReverseMap();

        //DeleteItemPackTypeCommand
        CreateMap<DeletedItemPackTypeResponse, ItemPackType>().ReverseMap();

        //GetByIdItemPackTypeQuery
        CreateMap<GetByIdItemPackTypeResponse, ItemPackType>().ReverseMap();

        //GetListByDynamicItemPackTypeQuery
        CreateMap<GetListByDynamicItemPackTypeListItemDto, ItemPackType>().ReverseMap();
        CreateMap<Paginate<ItemPackType>, GetListResponse<GetListByDynamicItemPackTypeListItemDto>>().ReverseMap();

    }
}
