using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.DtoProfiles;

public class ReturnItmStockAttrValueDtoMappingProfiles : Profile
{
    public ReturnItmStockAttrValueDtoMappingProfiles()
    {
        CreateMap<ReturnItmStockAttrValue, CreateReturnItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, CreateReturnItmStockAttrValueSubDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, UpdateReturnItmStockAttrValueDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, UpdateReturnItmStockAttrValueSubDto>().ReverseMap();
    }
}
