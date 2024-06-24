using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Profiles;

public class WorkTasksMappingProfiles : Profile
{
    public WorkTasksMappingProfiles()
    {

        //CreateWorkTaskCommand
        CreateMap<CreatedWorkTaskResponse, WorkTask>().ReverseMap();

        //UpdateWorkTaskCommand
        CreateMap<UpdatedWorkTaskResponse, WorkTask>().ReverseMap();

        //DeleteWorkTaskCommand
        CreateMap<DeletedWorkTaskResponse, WorkTask>().ReverseMap();

        //GetByCodeWorkTaskQuery
        CreateMap<GetByCodeWorkTaskResponse, WorkTask>().ReverseMap();

        //GetByIdWorkTaskQuery
        CreateMap<GetByIdWorkTaskResponse, WorkTask>().ReverseMap();

        //GetListWorkTaskQuery
        CreateMap<GetListWorkTaskListItemDto, WorkTask>().ReverseMap();
        CreateMap<Paginate<WorkTask>, GetListResponse<GetListWorkTaskListItemDto>>().ReverseMap();

        //GetListByDynamicWorkTaskQuery
        CreateMap<GetListByDynamicWorkTaskListItemDto, WorkTask>().ReverseMap();
        CreateMap<Paginate<WorkTask>, GetListResponse<GetListByDynamicWorkTaskListItemDto>>().ReverseMap();

    }
}

