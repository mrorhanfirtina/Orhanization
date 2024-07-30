using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Commands.Create;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Profiles;

public class ActionParameterDefaultsMappingProfiles : Profile
{
    public ActionParameterDefaultsMappingProfiles()
    {

        //CreateActionParameterDefaultCommand	
        CreateMap<CreatedActionParameterDefaultResponse, ActionParameterDefault>().ReverseMap();

        //UpdateActionParameterDefaultCommand	
        CreateMap<UpdatedActionParameterDefaultResponse, ActionParameterDefault>().ReverseMap();

        //DeleteActionParameterDefaultCommand	
        CreateMap<DeletedActionParameterDefaultResponse, ActionParameterDefault>().ReverseMap();

        //GetByIdActionParameterDefaultQuery	
        CreateMap<GetByIdActionParameterDefaultResponse, ActionParameterDefault>().ReverseMap();

        //GetListByDynamicActionParameterDefaultQuery	
        CreateMap<GetListByDynamicActionParameterDefaultListItemDto, ActionParameterDefault>().ReverseMap();
        CreateMap<Paginate<ActionParameterDefault>, GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>>().ReverseMap();

    }
}
