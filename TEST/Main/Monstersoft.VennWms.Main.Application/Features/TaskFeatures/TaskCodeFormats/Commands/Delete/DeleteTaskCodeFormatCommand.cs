using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Delete;

public class DeleteTaskCodeFormatCommand : IRequest<DeletedTaskCodeFormatResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TaskCodeFormatOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTaskCodeFormats";

    public Guid Id { get; set; }


    public class DeleteTaskCodeFormatCommandHandler : IRequestHandler<DeleteTaskCodeFormatCommand, DeletedTaskCodeFormatResponse>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;

        public DeleteTaskCodeFormatCommandHandler(ITaskCodeFormatRepository taskCodeFormatRepository, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
        }

        public async Task<DeletedTaskCodeFormatResponse> Handle(DeleteTaskCodeFormatCommand request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            TaskCodeFormat taskCodeFormat = await _taskCodeFormatRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _taskCodeFormatRepository.DeleteAsync(taskCodeFormat);

            return new DeletedTaskCodeFormatResponse
            {
                Id = taskCodeFormat.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = TaskCodeFormatMessages.RequestExecutedSuccessfully
            };
        }
    }
}
