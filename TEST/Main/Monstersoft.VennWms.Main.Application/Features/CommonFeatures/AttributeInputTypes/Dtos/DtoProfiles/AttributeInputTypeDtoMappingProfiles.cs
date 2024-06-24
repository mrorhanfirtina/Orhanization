using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AttributeInputTypes.Dtos.DtoProfiles;

public class AttributeInputTypeDtoMappingProfiles : Profile
{
    public AttributeInputTypeDtoMappingProfiles()
    {
        CreateMap<AttributeInputType, CreateAttributeInputTypeDto>().ReverseMap();
        CreateMap<AttributeInputType, UpdateAttributeInputTypeDto>().ReverseMap();
    }
}
