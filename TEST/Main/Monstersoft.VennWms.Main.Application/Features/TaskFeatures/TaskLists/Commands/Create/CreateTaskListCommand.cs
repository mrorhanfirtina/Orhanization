using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
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

            return _mapper.Map<CreatedTaskListResponse>(await _taskListRepository.AddAsync(taskList));
        }
    }
}

