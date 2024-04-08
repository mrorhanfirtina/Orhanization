using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Delete;

public class DeleteTaskListCommand : IRequest<DeletedTaskListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TaskListOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTaskLists";

    public Guid Id { get; set; }


    public class DeleteTaskListCommandHandler : IRequestHandler<DeleteTaskListCommand, DeletedTaskListResponse>
    {
        private readonly ITaskListRepository _taskListRepository;
        private readonly TaskListBusinessRules _taskListBusinessRules;

        public DeleteTaskListCommandHandler(ITaskListRepository taskListRepository, TaskListBusinessRules taskListBusinessRules)
        {
            _taskListRepository = taskListRepository;
            _taskListBusinessRules = taskListBusinessRules;
        }

        public async Task<DeletedTaskListResponse> Handle(DeleteTaskListCommand request, CancellationToken cancellationToken)
        {
            _taskListBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            TaskList taskList = await _taskListRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _taskListRepository.DeleteAsync(taskList);

            return new DeletedTaskListResponse
            {
                Id = taskList.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = taskList.DepositorId,
                IsSuccess = true,
                Message = TaskListMessages.RequestExecutedSuccessfully
            };
        }
    }
}

