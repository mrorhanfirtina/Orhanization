using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Dtos.ResponseDtos;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Dtos.DtoProfiles;

public class UserDtoMappingProfiles : Profile
{
    public UserDtoMappingProfiles()
    {
        CreateMap<User, UserSubResponseDto>();
    }
}
