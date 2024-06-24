using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.DtoProfiles;

public class UserDepositorDtoMappingProfiles : Profile
{
    public UserDepositorDtoMappingProfiles()
    {
        CreateMap<UserDepositor, CreateUserDepositorDto>().ReverseMap();
        CreateMap<UserDepositor, UpdateUserDepositorDto>().ReverseMap();

        CreateMap<User, UserDepositorUserResponseDto>().ReverseMap();
        CreateMap<Depositor, UserDepositorDepositorResponseDto>().ReverseMap();
    }
}
