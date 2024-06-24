using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Profiles;

public class UserDepositorsMappingProfiles : Profile
{
    public UserDepositorsMappingProfiles()
    {

        //CreateUserDepositorCommand
        CreateMap<CreatedUserDepositorResponse, UserDepositor>().ReverseMap();

        //UpdateUserDepositorCommand
        CreateMap<UpdatedUserDepositorResponse, UserDepositor>().ReverseMap();

        //DeleteUserDepositorCommand
        CreateMap<DeletedUserDepositorResponse, UserDepositor>().ReverseMap();

        //GetByIdUserDepositorQuery
        CreateMap<GetByIdUserDepositorResponse, UserDepositor>().ReverseMap();

        //GetListByDynamicUserDepositorQuery
        CreateMap<GetListByDynamicUserDepositorListItemDto, UserDepositor>().ReverseMap();
        CreateMap<Paginate<UserDepositor>, GetListResponse<GetListByDynamicUserDepositorListItemDto>>().ReverseMap();
    }

}
