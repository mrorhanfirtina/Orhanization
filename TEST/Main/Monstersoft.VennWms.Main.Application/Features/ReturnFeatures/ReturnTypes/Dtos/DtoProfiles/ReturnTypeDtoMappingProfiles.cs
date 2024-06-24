﻿using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.DtoProfiles;

public class ReturnTypeDtoMappingProfiles : Profile
{
    public ReturnTypeDtoMappingProfiles()
    {
        CreateMap<ReturnType, CreateReturnTypeDto>().ReverseMap();
        CreateMap<ReturnType, UpdateReturnTypeDto>().ReverseMap();

        CreateMap<DepositorCompany, ReturnTypesDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Return, ReturnTypesReturnResponseDto>().ReverseMap();
    }
}
