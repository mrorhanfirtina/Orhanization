using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.DtoProfiles;

public class PoAttributeValueDtoMappingProfiles : Profile
{
    public PoAttributeValueDtoMappingProfiles()
    {
        CreateMap<PoAttributeValue, CreatePoAttributeValueDto>().ReverseMap();
        CreateMap<PoAttributeValue, CreatePoAttributeValueSubDto>().ReverseMap();
        CreateMap<PoAttributeValue, UpdatePoAttributeValueDto>().ReverseMap();
        CreateMap<PoAttributeValue, UpdatePoAttributeValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, PoAttributeValueAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<PoAttribute, PoAttributeValuePoAttributeResponseDto>().ReverseMap();
        CreateMap<PurchaseOrder, PoAttributeValuePurchaseOrderResponseDto>().ReverseMap();
    }
}
