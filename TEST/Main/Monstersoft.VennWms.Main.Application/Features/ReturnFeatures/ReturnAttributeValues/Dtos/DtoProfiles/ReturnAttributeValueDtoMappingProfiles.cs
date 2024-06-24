﻿using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoProfiles;

public class ReturnAttributeValueDtoMappingProfiles : Profile
{
    public ReturnAttributeValueDtoMappingProfiles()
    {
        CreateMap<ReturnAttributeValue, CreateReturnAttributeValueDto>().ReverseMap();
        CreateMap<ReturnAttributeValue, CreateReturnAttributeValueSubDto>().ReverseMap();
        CreateMap<ReturnAttributeValue, UpdateReturnAttributeValueDto>().ReverseMap();
        CreateMap<ReturnAttributeValue, UpdateReturnAttributeValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReturnAttributeValuesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<ReturnAttribute, ReturnAttributeValuesReturnAttributeResponseDto>().ReverseMap();
        CreateMap<Return, ReturnAttributeValuesReturnResponseDto>().ReverseMap();
    }
}
