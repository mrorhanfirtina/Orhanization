using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Profiles;

public class TaskListsMappingProfiles : Profile
{
    public TaskListsMappingProfiles()
    {

        //CreateTaskListCommand
        CreateMap<CreatedTaskListResponse, TaskList>().ReverseMap();

        //UpdateTaskListCommand
        CreateMap<UpdatedTaskListResponse, TaskList>().ReverseMap();

        //DeleteTaskListCommand
        CreateMap<DeletedTaskListResponse, TaskList>().ReverseMap();

        //GetByCodeTaskListQuery
        CreateMap<GetByCodeTaskListResponse, TaskList>().ReverseMap();

        //GetByIdTaskListQuery
        CreateMap<GetByIdTaskListResponse, TaskList>().ReverseMap();

        //GetListTaskListQuery
        CreateMap<GetListTaskListListItemDto, TaskList>().ReverseMap();
        CreateMap<Paginate<TaskList>, GetListResponse<GetListTaskListListItemDto>>().ReverseMap();

        //GetListByDynamicTaskListQuery
        CreateMap<GetListByDynamicTaskListListItemDto, TaskList>().ReverseMap();
        CreateMap<Paginate<TaskList>, GetListResponse<GetListByDynamicTaskListListItemDto>>().ReverseMap();

    }
}

