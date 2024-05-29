using AutoMapper;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.DtoProfiles;

public class WorkTaskDtoMappingProfiles : Profile
{
    public WorkTaskDtoMappingProfiles()
    {
        CreateMap<WorkTask, CreateWorkTaskDto>().ReverseMap();
        CreateMap<WorkTask, CreateWorkTaskSubDto>().ReverseMap();
        CreateMap<WorkTask, UpdateWorkTaskDto>().ReverseMap();
        CreateMap<WorkTask, UpdateWorkTaskSubDto>().ReverseMap();
    }
}
