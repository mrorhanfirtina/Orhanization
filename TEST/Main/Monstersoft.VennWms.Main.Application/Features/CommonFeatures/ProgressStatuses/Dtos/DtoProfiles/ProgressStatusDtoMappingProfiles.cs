using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.DtoProfiles;

public class ProgressStatusDtoMappingProfiles : Profile
{
    public ProgressStatusDtoMappingProfiles()
    {
        CreateMap<ProgressStatus, CreateProgressStatusDto>().ReverseMap();
        CreateMap<ProgressStatus, UpdateProgressStatusDto>().ReverseMap();
    }
}
