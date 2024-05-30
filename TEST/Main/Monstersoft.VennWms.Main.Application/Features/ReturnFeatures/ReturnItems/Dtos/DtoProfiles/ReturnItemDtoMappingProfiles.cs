using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoProfiles;

public class ReturnItemDtoMappingProfiles : Profile
{
    public ReturnItemDtoMappingProfiles()
    {
        CreateMap<ReturnItem, CreateReturnItemDto>().ReverseMap();
        CreateMap<ReturnItem, CreateReturnItemSubDto>().ReverseMap();
        CreateMap<ReturnItem, UpdateReturnItemDto>().ReverseMap();
        CreateMap<ReturnItem, UpdateReturnItemSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReturnItemsAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ReturnItemsItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ReturnItemsProductResponseDto>().ReverseMap();
        CreateMap<ReturnItemMemo, ReturnItemsReturnItemMemoResponseDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, ReturnItemsReturnItmStockAttrValueResponseDto>().ReverseMap();
        CreateMap<Return, ReturnItemsReturnResponseDto>().ReverseMap();
        CreateMap<Status, ReturnItemsStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReturnItemsStockAttributeResponseDto>().ReverseMap();
        CreateMap<Unit, ReturnItemsUnitResponseDto>().ReverseMap();
    }
}
