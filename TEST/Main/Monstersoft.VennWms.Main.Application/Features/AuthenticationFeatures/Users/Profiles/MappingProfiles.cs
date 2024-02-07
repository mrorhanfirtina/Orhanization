using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.UpdateFromAuth;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Queries.GetList;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, CreatedUserResponse>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        CreateMap<User, UpdatedUserResponse>().ReverseMap();
        CreateMap<User, UpdateUserFromAuthCommand>().ReverseMap();
        CreateMap<User, UpdatedUserFromAuthResponse>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
        CreateMap<User, DeletedUserResponse>().ReverseMap();
        CreateMap<User, GetByIdUserResponse>().ReverseMap();
        CreateMap<User, GetListUserListItemDto>().ReverseMap();
        CreateMap<Paginate<User>, GetListResponse<GetListUserListItemDto>>().ReverseMap();
        
        CreateMap<User, CreateUserWithClaimsCommand>().ReverseMap();
        CreateMap<User, CreatedUserWithClaimsResponse>().ReverseMap();
    }
}

