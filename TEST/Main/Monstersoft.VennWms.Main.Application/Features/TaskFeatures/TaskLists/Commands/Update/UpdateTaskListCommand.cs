using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants.TaskListOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;

public class UpdateTaskListCommand : IRequest<UpdatedTaskListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, TaskListOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskLists"];

    public UpdateTaskListDto TaskList { get; set; }
    public TaskListsDetailLevel? DetailLevel { get; set; }


    public class UpdateTaskListCommandHandler : IRequestHandler<UpdateTaskListCommand, UpdatedTaskListResponse>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly IMapper _mapper;
        private readonly TaskListBusinessRules _taskListBusinessRules;

        public UpdateTaskListCommandHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _mapper = mapper;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<UpdatedTaskListResponse> Handle(UpdateTaskListCommand request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.TaskList.Id);

            TaskList? currentTaskList = await _taskListRepository.GetAsync(predicate: x => x.Id == request.TaskList.Id,
            include: x => x.Include(y => y.WorkTasks),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            TaskList? taskList = _mapper.Map(request.TaskList, currentTaskList);
            taskList.UpdatedDate = DateTime.Now;

            taskList.WorkTasks?.ToList().ForEach(x =>
            {
                x.CreatedDate = taskList.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            await _taskListRepository.UpdateAsync(taskList);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _taskListRepository.GetAsync(predicate: x => x.Id == taskList.Id,
                include: x =>
                {
                    IQueryable<TaskList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeWorkTask)
                    {
                        query = query.Include(y => y.WorkTasks);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        var depositorDetailLevel = detailLevel.DepositorDetailLevel;

                        if (depositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(y => y.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<TaskList, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedTaskListResponse>(response);
            }
            else
            {
                var response = await _taskListRepository.GetAsync(predicate: x => x.Id == taskList.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedTaskListResponse>(response);
            }
        }
    }
}

