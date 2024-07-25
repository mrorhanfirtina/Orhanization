using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Profiles;

public class ActionParameterCategoryMappingProfiles : Profile
{
    public ActionParameterCategoryMappingProfiles()
    {
        //CreateActionParameterCategoryCommand
        CreateMap<CreatedActionParameterCategoryResponse, ActionParameterCategory>().ReverseMap();

        //UpdateActionParameterCategoryCommand
        CreateMap<UpdatedActionParameterCategoryResponse, ActionParameterCategory>().ReverseMap();

        //DeleteActionParameterCategoryCommand
        CreateMap<DeletedActionParameterCategoryResponse, ActionParameterCategory>().ReverseMap();

        //GetByIdActionParameterCategoryQuery
        CreateMap<GetByIdActionParameterCategoryResponse, ActionParameterCategory>().ReverseMap();

        //GetListByDynamicActionParameterCategoryQuery
        CreateMap<ActionParameterCategory, GetListByDynamicActionParameterCategoryListItemDto>().ReverseMap();
        CreateMap<Paginate<ActionParameterCategory>, GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>>().ReverseMap();
    }
}
