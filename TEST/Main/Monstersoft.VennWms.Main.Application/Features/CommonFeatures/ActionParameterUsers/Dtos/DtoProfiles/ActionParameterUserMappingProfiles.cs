using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.DtoProfiles;

public class ActionParameterUserMappingProfiles : Profile
{
    public ActionParameterUserMappingProfiles()
    {
        CreateMap<ActionParameterUser, CreateActionParameterUserDto>().ReverseMap();
        CreateMap<ActionParameterUser, UpdateActionParameterUserDto>().ReverseMap();

        CreateMap<ActionParameter, ActionParameterUserParameterResponseDto>().ReverseMap();
        CreateMap<ActionParameterCategory, ActionParameterUserParameterCategoryResponseDto>().ReverseMap();
        CreateMap<User, ActionParameterUserUserResponseDto>().ReverseMap();
    }
}
