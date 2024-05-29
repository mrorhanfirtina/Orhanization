using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.DtoProfiles;

public class TaskListDtoMappingProfiles : Profile
{
    public TaskListDtoMappingProfiles()
    {
        CreateMap<TaskList, CreateTaskListDto>().ReverseMap();
        CreateMap<TaskList, UpdateTaskListDto>().ReverseMap();
    }
}
