using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.DtoProfiles;

public class ActionParameterDepositorMappingProfiles : Profile
{
    public ActionParameterDepositorMappingProfiles()
    {
        CreateMap<ActionParameterDepositor, CreateActionParameterDepositorDto>().ReverseMap();
        CreateMap<ActionParameterDepositor, UpdateActionParameterDepositorDto>().ReverseMap();

        CreateMap<ActionParameter, ActionParameterDepositorParameterResponseDto>().ReverseMap();
        CreateMap<ActionParameterCategory, ActionParameterDepositorParameterCategoryResponseDto>().ReverseMap();
        CreateMap<Depositor, ActionParameterDepositorDepositorResponseDto>().ReverseMap();
        CreateMap<Company, ActionParameterDepositorCompanyResponseDto>().ReverseMap();
    }
}
