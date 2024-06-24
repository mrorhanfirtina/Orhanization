using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.DtoProfiles;

public class ReceiptItemDtoMappingProfiles : Profile
{
    public ReceiptItemDtoMappingProfiles()
    {
        CreateMap<ReceiptItem, CreateReceiptItemDto>().ReverseMap();
        CreateMap<ReceiptItem, CreateReceiptItemSubDto>().ReverseMap();
        CreateMap<ReceiptItem, UpdateReceiptItemDto>().ReverseMap();
        CreateMap<ReceiptItem, UpdateReceiptItemSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReceiptItemsAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ReceiptItemsItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ReceiptItemsProductResponseDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, ReceiptItemsReceiptItemMemoResponseDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, ReceiptItemsReceiptItmStockAttrValueResponseDto>().ReverseMap();
        CreateMap<Receipt, ReceiptItemsReceiptResponseDto>().ReverseMap();
        CreateMap<Status, ReceiptItemsStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReceiptItemsStockAttributeResponseDto>().ReverseMap();
        CreateMap<Unit, ReceiptItemsUnitResponseDto>().ReverseMap();
    }
}
