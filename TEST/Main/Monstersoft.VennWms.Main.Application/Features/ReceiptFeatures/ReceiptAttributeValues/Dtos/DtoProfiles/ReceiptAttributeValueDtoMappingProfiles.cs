﻿using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.DtoProfiles;

public class ReceiptAttributeValueDtoMappingProfiles : Profile
{
    public ReceiptAttributeValueDtoMappingProfiles()
    {
        CreateMap<ReceiptAttributeValue, CreateReceiptAttributeValueDto>().ReverseMap();
        CreateMap<ReceiptAttributeValue, CreateReceiptAttributeValueSubDto>().ReverseMap();
        CreateMap<ReceiptAttributeValue, UpdateReceiptAttributeValueDto>().ReverseMap();
        CreateMap<ReceiptAttributeValue, UpdateReceiptAttributeValueSubDto>().ReverseMap();
    }
}