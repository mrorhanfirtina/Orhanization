using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Dtos.DtoProfiles;

public class StatusDtoMappingProfiles : Profile
{
    public StatusDtoMappingProfiles()
    {
        CreateMap<Status, CreateStatusDto>().ReverseMap();
        CreateMap<Status, UpdateStatusDto>().ReverseMap();
    }
}
