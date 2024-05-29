using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.DtoProfiles;

public class ReceiptItmStockAttrValueDtoMappingProfiles : Profile
{
    public ReceiptItmStockAttrValueDtoMappingProfiles()
    {
        CreateMap<ReceiptItmStockAttrValue, CreateReceiptItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, CreateReceiptItmStockAttrValueSubDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, UpdateReceiptItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, UpdateReceiptItmStockAttrValueSubDto>().ReverseMap();
    }
}
