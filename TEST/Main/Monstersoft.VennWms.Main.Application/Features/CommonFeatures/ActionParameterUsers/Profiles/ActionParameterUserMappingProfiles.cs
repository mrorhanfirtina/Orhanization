using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Profiles;

public class ActionParameterUserMappingProfiles : Profile
{
    public ActionParameterUserMappingProfiles()
    {
        //CreateActionParameterUserCommand
        CreateMap<CreatedActionParameterUserResponse, ActionParameterUser>().ReverseMap();

        //UpdateActionParameterUserCommand
        CreateMap<UpdatedActionParameterUserResponse, ActionParameterUser>().ReverseMap();

        //DeleteActionParameterUserCommand
        CreateMap<DeletedActionParameterUserResponse, ActionParameterUser>().ReverseMap();

        //GetByIdActionParameterUserQuery
        CreateMap<GetByIdActionParameterUserResponse, ActionParameterUser>().ReverseMap();

        //GetListByDynamicActionParameterUserQuery
        CreateMap<ActionParameterUser, GetListByDynamicActionParameterUserListItemDto>().ReverseMap();
        CreateMap<Paginate<ActionParameterUser>, GetListResponse<GetListByDynamicActionParameterUserListItemDto>>().ReverseMap();
    }
}
