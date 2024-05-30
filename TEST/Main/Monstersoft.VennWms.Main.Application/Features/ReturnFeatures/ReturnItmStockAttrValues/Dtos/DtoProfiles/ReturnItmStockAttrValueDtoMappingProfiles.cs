using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.DtoProfiles;

public class ReturnItmStockAttrValueDtoMappingProfiles : Profile
{
    public ReturnItmStockAttrValueDtoMappingProfiles()
    {
        CreateMap<ReturnItmStockAttrValue, CreateReturnItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, CreateReturnItmStockAttrValueSubDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, UpdateReturnItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, UpdateReturnItmStockAttrValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReturnItmStockAttrValuesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Product, ReturnItmStockAttrValuesProductResponseDto>().ReverseMap();
        CreateMap<ReturnItem, ReturnItmStockAttrValuesReturnItemResponseDto>().ReverseMap();
        CreateMap<Return, ReturnItmStockAttrValuesReturnResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReturnItmStockAttrValuesStockAttributeResponseDto>().ReverseMap();
    }
}
