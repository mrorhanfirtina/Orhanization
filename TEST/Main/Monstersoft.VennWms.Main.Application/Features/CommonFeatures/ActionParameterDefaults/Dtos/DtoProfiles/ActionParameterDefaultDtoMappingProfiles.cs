using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.DtoProfiles;

public class ActionParameterDefaultDtoMappingProfiles : Profile
{
    public ActionParameterDefaultDtoMappingProfiles()
    {
        CreateMap<ActionParameterDefault, CreateActionParameterDefaultDto>().ReverseMap();
        CreateMap<ActionParameterDefault, CreateActionParameterDefaultSubDto>().ReverseMap();
        CreateMap<ActionParameterDefault, UpdateActionParameterDefaultDto>().ReverseMap();
        CreateMap<ActionParameterDefault, UpdateActionParameterDefaultSubDto>().ReverseMap();

        CreateMap<ActionParameterDefaultDepositorCompanyResponseDto, DepositorCompany>().ReverseMap();
        CreateMap<ActionParameterDefaultParameterResponseDto, ActionParameter>().ReverseMap();
    }
}
