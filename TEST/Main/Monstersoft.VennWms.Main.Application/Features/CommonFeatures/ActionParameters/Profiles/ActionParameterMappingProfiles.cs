using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByUserToken;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Profiles;

public class ActionParameterMappingProfiles : Profile
{
    public ActionParameterMappingProfiles()
    {
        //CreateActionParameterCommand
        CreateMap<CreatedActionParameterResponse, ActionParameter>().ReverseMap();

        //UpdateActionParameterCommand
        CreateMap<UpdatedActionParameterResponse, ActionParameter>().ReverseMap();

        //DeleteActionParameterCommand
        CreateMap<DeletedActionParameterResponse, ActionParameter>().ReverseMap();

        //GetByIdActionParameterQuery
        CreateMap<GetByIdActionParameterResponse, ActionParameter>().ReverseMap();

        //GetListByUserTokenActionParameterQuery
        CreateMap<ActionParameter, GetListByUserTokenActionParameterListItemDto>().ReverseMap();
        CreateMap<List<ActionParameter>, GetListResponse<GetListByUserTokenActionParameterListItemDto>>().ReverseMap();

        //GetListByDynamicActionParameterQuery
        CreateMap<ActionParameter, GetListByDynamicActionParameterListItemDto>().ReverseMap();
        CreateMap<Paginate<ActionParameter>, GetListResponse<GetListByDynamicActionParameterListItemDto>>().ReverseMap();

        //GetListBeforeBusiness
        CreateMap<Paginate<ActionParameter>, List<ActionParameter>>().ReverseMap();
        CreateMap<Paginate<ActionParameterUser>, List<ActionParameterUser>>().ReverseMap();
        CreateMap<Paginate<ActionParameterDefault>, List<ActionParameterDefault>>().ReverseMap();
        CreateMap<Paginate<ActionParameterDepositor>, List<ActionParameterDepositor>>().ReverseMap();
    }
}
