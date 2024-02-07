using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Queries.GetList;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<OperationClaim, CreateOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, CreatedOperationClaimResponse>().ReverseMap();
        CreateMap<OperationClaim, UpdateOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, UpdatedOperationClaimResponse>().ReverseMap();
        CreateMap<OperationClaim, DeleteOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, DeletedOperationClaimResponse>().ReverseMap();
        CreateMap<OperationClaim, GetByIdOperationClaimResponse>().ReverseMap();
        CreateMap<OperationClaim, GetListOperationClaimListItemDto>().ReverseMap();
        CreateMap<Paginate<OperationClaim>, GetListResponse<GetListOperationClaimListItemDto>>().ReverseMap();
    }
}
