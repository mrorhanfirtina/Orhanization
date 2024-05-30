using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;

public class CreateTaskListCommand : IRequest<CreatedTaskListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTaskLists";

    public CreateTaskListDto TaskList { get; set; }
    public TaskListsDetailLevel? DetailLevel { get; set; }


    public class CreateTaskListCommandHandler : IRequestHandler<CreateTaskListCommand, CreatedTaskListResponse>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly IMapper _mapper;
        private readonly TaskListBusinessRules _taskListBusinessRules;

        public CreateTaskListCommandHandler(ITaskListRepository taskListRepository, IMapper mapper, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _mapper = mapper;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<CreatedTaskListResponse> Handle(CreateTaskListCommand request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            TaskList? taskList = _mapper.Map<TaskList>(request.TaskList);

            taskList.CreatedDate = DateTime.Now;
            taskList.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            taskList.WorkTasks?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            await _taskListRepository.AddAsync(taskList);

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

                return _mapper.Map<CreatedTaskListResponse>(response);
            }
            else
            {
                var response = await _taskListRepository.GetAsync(predicate: x => x.Id == taskList.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTaskListResponse>(response);
            }
        }
    }
}

