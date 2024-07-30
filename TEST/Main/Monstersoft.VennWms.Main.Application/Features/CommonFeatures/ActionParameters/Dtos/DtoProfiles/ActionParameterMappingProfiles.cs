using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.DtoProfiles;

public class ActionParameterMappingProfiles : Profile
{
    public ActionParameterMappingProfiles()
    {
        CreateMap<ActionParameter, CreateActionParameterDto>().ReverseMap();
        CreateMap<ActionParameter, UpdateActionParameterDto>().ReverseMap();

        CreateMap<ActionParameterCategory, ActionParameterParameterCategoryResponseDto>().ReverseMap();
        CreateMap<ActionParameterUser, ActionParameterParameterUserResponseDto>().ReverseMap();
        CreateMap<ActionParameterDepositor, ActionParameterParameterDepositorResponseDto>().ReverseMap();
        CreateMap<User, ActionParameterUserResponseDto>().ReverseMap();
        CreateMap<Depositor, ActionParameterDepositorResponseDto>().ReverseMap();
        CreateMap<Company, ActionParameterCompanyResponseDto>().ReverseMap();
    }
}
