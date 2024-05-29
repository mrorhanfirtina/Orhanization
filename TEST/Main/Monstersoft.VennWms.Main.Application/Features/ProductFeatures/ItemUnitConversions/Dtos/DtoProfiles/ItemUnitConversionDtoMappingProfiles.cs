using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Dtos.DtoProfiles;

public class ItemUnitConversionDtoMappingProfiles : Profile
{
    public ItemUnitConversionDtoMappingProfiles()
    {
        CreateMap<ItemUnitConversion, CreateItemUnitConversionDto>().ReverseMap();
        CreateMap<ItemUnitConversion, UpdateItemUnitConversionDto>().ReverseMap();
        CreateMap<ItemUnitConversion, UpdateItemUnitConversionSubDto>().ReverseMap();
        CreateMap<ItemUnitConversion, CreateItemUnitConversionSubDto>().ReverseMap();

        CreateMap<ItemUnit, ItemUnitConversionConvertedItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ItemUnitConversionProductResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ItemUnitConversionReferenceItemUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemUnitConversionUnitResponseDto>().ReverseMap();
    }
}
