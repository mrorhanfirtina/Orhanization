using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Profiles;

public class ItemUnitsMappingProfiles : Profile
{
    public ItemUnitsMappingProfiles()
    {

        //CreateItemUnitCommand
        CreateMap<CreatedItemUnitResponse, ItemUnit>().ReverseMap();

        //UpdateItemUnitCommand
        CreateMap<UpdatedItemUnitResponse, ItemUnit>().ReverseMap();

        //DeleteItemUnitCommand
        CreateMap<DeletedItemUnitResponse, ItemUnit>().ReverseMap();

        //GetByIdItemUnitQuery
        CreateMap<GetByIdItemUnitResponse, ItemUnit>().ReverseMap();

        //GetListByDynamicItemUnitQuery
        CreateMap<GetListByDynamicItemUnitListItemDto, ItemUnit>().ReverseMap();
        CreateMap<Paginate<ItemUnit>, GetListResponse<GetListByDynamicItemUnitListItemDto>>().ReverseMap();

    }
}
