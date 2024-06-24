using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Delete;

public class DeleteWorkTaskCommand : IRequest<DeletedWorkTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, WorkTaskOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetWorkTasks";

    public Guid Id { get; set; }


    public class DeleteWorkTaskCommandHandler : IRequestHandler<DeleteWorkTaskCommand, DeletedWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;

        public DeleteWorkTaskCommandHandler(IWorkTaskRepository workTaskRepository, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<DeletedWorkTaskResponse> Handle(DeleteWorkTaskCommand request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            WorkTask workTask = await _workTaskRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _workTaskRepository.DeleteAsync(workTask);

            return new DeletedWorkTaskResponse
            {
                Id = workTask.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = workTask.DepositorId,
                IsSuccess = true,
                Message = WorkTaskMessages.RequestExecutedSuccessfully
            };
        }
    }
}

