using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.DtoProfiles;

public class ItemPackTypeDtoMappingProfiles : Profile
{
    public ItemPackTypeDtoMappingProfiles()
    {
        CreateMap<ItemPackType, CreateItemPackTypeDto>().ReverseMap();
        CreateMap<ItemPackType, CreateItemPackTypeSubDto>().ReverseMap();
        CreateMap<ItemPackType, UpdateItemPackTypeDto>().ReverseMap();
        CreateMap<ItemPackType, UpdateItemPackTypeSubDto>().ReverseMap();

        CreateMap<ItemUnit, ItemPackTypeItemUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemPackTypeLenghtUnitResponseDto>().ReverseMap();
        CreateMap<Product, ItemPackTypeProductResponseDto>().ReverseMap();
        CreateMap<Unit, ItemPackTypeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemPackTypeVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ItemPackTypeWeightUnitResponseDto>().ReverseMap();
    }
}
