using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.DtoProfiles;

public class ItemUnitDtoMappingProfiles : Profile
{
    public ItemUnitDtoMappingProfiles()
    {
        CreateMap<ItemUnit, CreateItemUnitDto>().ReverseMap();
        CreateMap<ItemUnit, CreateItemUnitSubDto>().ReverseMap();
        CreateMap<ItemUnit, UpdateItemUnitDto>().ReverseMap();
        CreateMap<ItemUnit, UpdateItemUnitSubDto>().ReverseMap();

        CreateMap<ItemUnit, ItemUnitConvertedItemUnitResponseDto>().ReverseMap();
        CreateMap<ItemPackType, ItemUnitItemPackTypeResponseDto>().ReverseMap();
        CreateMap<ItemUnitConversion, ItemUnitItemUnitConversionResponseDto>().ReverseMap();
        CreateMap<Unit, ItemUnitLenghtUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemUnitUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemUnitVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemUnitWeightUnitResponseDto>().ReverseMap();
        CreateMap<Product, ItemUnitProductResponseDto>().ReverseMap();
    }
}
