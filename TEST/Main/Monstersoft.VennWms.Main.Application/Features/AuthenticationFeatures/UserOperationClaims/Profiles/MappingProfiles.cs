using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Queries.GetList;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<UserOperationClaim, CreateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, CreatedUserOperationClaimResponse>().ReverseMap();
        CreateMap<UserOperationClaim, UpdateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, UpdatedUserOperationClaimResponse>().ReverseMap();
        CreateMap<UserOperationClaim, DeleteUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, DeletedUserOperationClaimResponse>().ReverseMap();
        CreateMap<UserOperationClaim, GetByIdUserOperationClaimResponse>().ReverseMap();
        CreateMap<UserOperationClaim, GetListUserOperationClaimListItemDto>().ReverseMap();
        CreateMap<Paginate<UserOperationClaim>, GetListResponse<GetListUserOperationClaimListItemDto>>().ReverseMap();
    }
}