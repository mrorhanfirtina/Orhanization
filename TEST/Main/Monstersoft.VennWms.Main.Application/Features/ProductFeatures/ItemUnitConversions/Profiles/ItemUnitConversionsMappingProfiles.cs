using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Profiles;

public class ItemUnitConversionsMappingProfiles : Profile
{
    public ItemUnitConversionsMappingProfiles()
    {

        //CreateItemUnitConversionCommand
        CreateMap<CreatedItemUnitConversionResponse, ItemUnitConversion>().ReverseMap();

        //UpdateItemUnitConversionCommand
        CreateMap<UpdatedItemUnitConversionResponse, ItemUnitConversion>().ReverseMap();

        //DeleteItemUnitConversionCommand
        CreateMap<DeletedItemUnitConversionResponse, ItemUnitConversion>().ReverseMap();

        //GetByIdItemUnitConversionQuery
        CreateMap<GetByIdItemUnitConversionResponse, ItemUnitConversion>().ReverseMap();

        //GetListByDynamicItemUnitConversionQuery
        CreateMap<GetListByDynamicItemUnitConversionListItemDto, ItemUnitConversion>().ReverseMap();
        CreateMap<Paginate<ItemUnitConversion>, GetListResponse<GetListByDynamicItemUnitConversionListItemDto>>().ReverseMap();

    }
}

