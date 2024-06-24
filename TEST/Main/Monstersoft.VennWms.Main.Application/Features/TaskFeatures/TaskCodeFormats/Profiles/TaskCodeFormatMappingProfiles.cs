using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Profiles;

public class TaskCodeFormatMappingProfiles : Profile
{
    public TaskCodeFormatMappingProfiles()
    {

        //CreateTaskCodeFormatCommand
        CreateMap<CreatedTaskCodeFormatResponse, TaskCodeFormat>().ReverseMap();

        //UpdateTaskCodeFormatCommand
        CreateMap<UpdatedTaskCodeFormatResponse, TaskCodeFormat>().ReverseMap();

        //DeleteTaskCodeFormatCommand
        CreateMap<DeletedTaskCodeFormatResponse, TaskCodeFormat>().ReverseMap();

        //GetByCodeTaskCodeFormatQuery
        CreateMap<GetByCodeTaskCodeFormatResponse, TaskCodeFormat>().ReverseMap();

        //GetByIdTaskCodeFormatQuery
        CreateMap<GetByIdTaskCodeFormatResponse, TaskCodeFormat>().ReverseMap();

        //GetListTaskCodeFormatQuery
        CreateMap<GetListTaskCodeFormatListItemDto, TaskCodeFormat>().ReverseMap();
        CreateMap<Paginate<TaskCodeFormat>, GetListResponse<GetListTaskCodeFormatListItemDto>>().ReverseMap();

        //GetListByDynamicTaskCodeFormatQuery
        CreateMap<GetListByDynamicTaskCodeFormatListItemDto, TaskCodeFormat>().ReverseMap();
        CreateMap<Paginate<TaskCodeFormat>, GetListResponse<GetListByDynamicTaskCodeFormatListItemDto>>().ReverseMap();

    }
}
