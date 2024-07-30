using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.DtoProfiles;

public class ActionParameterCategoryMappingProfiles : Profile
{
    public ActionParameterCategoryMappingProfiles()
    {
        CreateMap<ActionParameterCategory, CreateActionParameterCategoryDto>().ReverseMap();
        CreateMap<ActionParameterCategory, UpdateActionParameterCategoryDto>().ReverseMap();

        CreateMap<ActionParameter, ActionParameterCategoryParameterResponseDto>().ReverseMap();
    }
}
