using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.DtoProfiles;

public class ReceiptItmStockAttrValueDtoMappingProfiles : Profile
{
    public ReceiptItmStockAttrValueDtoMappingProfiles()
    {
        CreateMap<ReceiptItmStockAttrValue, CreateReceiptItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, CreateReceiptItmStockAttrValueSubDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, UpdateReceiptItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, UpdateReceiptItmStockAttrValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReceiptItmStockAttrValuesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Product, ReceiptItmStockAttrValuesProductResponseDto>().ReverseMap();
        CreateMap<ReceiptItem, ReceiptItmStockAttrValuesReceiptItemResponseDto>().ReverseMap();
        CreateMap<Receipt, ReceiptItmStockAttrValuesReceiptResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReceiptItmStockAttrValuesStockAttributeResponseDto>().ReverseMap();
    }
}
