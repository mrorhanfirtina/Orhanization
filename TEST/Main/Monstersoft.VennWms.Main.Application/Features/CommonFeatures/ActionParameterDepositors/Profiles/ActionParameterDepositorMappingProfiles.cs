using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Profiles;

public class ActionParameterDepositorMappingProfiles : Profile
{
    public ActionParameterDepositorMappingProfiles()
    {
        //CreateActionParameterDepositorCommand
        CreateMap<CreatedActionParameterDepositorResponse, ActionParameterDepositor>().ReverseMap();

        //UpdateActionParameterDepositorCommand
        CreateMap<UpdatedActionParameterDepositorResponse, ActionParameterDepositor>().ReverseMap();

        //DeleteActionParameterDepositorCommand
        CreateMap<DeletedActionParameterDepositorResponse, ActionParameterDepositor>().ReverseMap();

        //GetByIdActionParameterDepositorQuery
        CreateMap<GetByIdActionParameterDepositorResponse, ActionParameterDepositor>().ReverseMap();

        //GetListByDynamicActionParameterDepositorQuery
        CreateMap<ActionParameterDepositor, GetListByDynamicActionParameterDepositorListItemDto>().ReverseMap();
        CreateMap<Paginate<ActionParameterDepositor>, GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>>().ReverseMap();
    }
}